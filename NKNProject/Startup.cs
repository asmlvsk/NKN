using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MudBlazor;
using MudBlazor.Services;
using NKNProject.DataAccess;
using NKNProject.Models;
using System.Net.Http;

namespace NKNProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();            
            services.AddServerSideBlazor();

            services.AddMudServices();

            services.AddAuthentication("Cookies")
                .AddCookie(opt =>
                {
                    opt.Cookie.Name = "AuthCookie";
                })
                .AddMicrosoftAccount(opt =>
                {
                    opt.SignInScheme = "Cookies";
                    opt.ClientId = Configuration["Microsoft:Id"];
                    opt.ClientSecret = Configuration["Microsoft:Secret"];
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
        }
    }
}
