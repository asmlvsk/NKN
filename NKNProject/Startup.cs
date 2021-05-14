using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MudBlazor;
using MudBlazor.Services;
using NKNProject.DataAccess;
using NKNProject.Helpers;
using NKNProject.Models;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Net.Http;
using static SpotifyAPI.Web.Scopes;

namespace NKNProject
{
    public class Startup
    {
        private string[] _secrets = null;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            _secrets = new string[]
            {
                Configuration["DatabaseSettings:ConnectionString"],
                Configuration["DatabaseSettings:DatabaseName"],
                Configuration["Microsoft:Id"],
                Configuration["Microsoft:Secret"],
                Configuration["SpotifySettings:ClientID"],
                Configuration["SpotifySettings:ClientSecret"],
            };
            services.AddHttpContextAccessor();
            services.AddSingleton(SpotifyClientConfig.CreateDefault());
            services.AddScoped<SpotifyBuilder>();
         
            services.AddServerSideBlazor();

            services.AddMudServices();

            services.AddAuthorization(options => 
            {
                options.AddPolicy("Spotify", policy =>
                {
                    policy.AuthenticationSchemes.Add("Spotify");
                    policy.RequireAuthenticatedUser();
                });
            });

            services.AddAuthentication(opt => { 
                opt.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(opt =>
            {
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(50);
                //opt.Cookie.Name = "AuthCookie";
            })
            .AddSpotify(opt =>
            {
                opt.ClientId = Configuration["SpotifySettings:ClientID"];
                opt.ClientSecret = Configuration["SpotifySettings:ClientSecret"];
                opt.CallbackPath = "/Auth/callback";
                opt.SaveTokens = true;

                var scopes = new List<string> {
                    UserReadEmail, UserReadPrivate, PlaylistReadPrivate, PlaylistReadCollaborative, UserLibraryRead, UserFollowRead, UserTopRead
                };
                opt.Scope.Add(string.Join(",", scopes));
            })
            .AddMicrosoftAccount(opt =>
            {
                opt.SignInScheme = "Cookies";
                opt.ClientId = Configuration["Microsoft:Id"];
                opt.ClientSecret = Configuration["Microsoft:Secret"];
            });
            services.AddRazorPages(options => {
                options.Conventions.AuthorizeFolder("/", "Spotify");
            });

            services.AddScoped<HttpClient>();
            services.AddScoped<DialogService>();
            services.AddControllers();
            services.AddSingleton<TrackDataAccess>();

            services.Configure<DatabaseSettings>(Configuration.GetSection(nameof(DatabaseSettings)));
            services.AddSingleton<IDatabaseSettings>(x => x.GetRequiredService<IOptions<DatabaseSettings>>().Value);

            services.Configure<SpotifySettings>(Configuration.GetSection(nameof(SpotifySettings)));
            services.AddSingleton<ISpotifySettings>(x => x.GetRequiredService<IOptions<SpotifySettings>>().Value);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            app.Run(async (context) =>
            {
                foreach (string secret in _secrets)
                {
                    var result = string.IsNullOrEmpty(secret) ? "Null" : "Not Null";
                    await context.Response.WriteAsync($"Secret is {result}");
                }
            });
        }
    }
}
