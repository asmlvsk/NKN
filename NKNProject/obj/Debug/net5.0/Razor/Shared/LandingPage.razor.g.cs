#pragma checksum "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f236f14dbda0502e9c78cb1e22e3e92668db79ac"
// <auto-generated/>
#pragma warning disable 1591
namespace NKNProject.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using NKNProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using NKNProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using NKNProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using SpotifyAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using SpotifyAPI.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using SpotifyAPI.Web.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using NKNProject.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class LandingPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "header");
            __builder.AddAttribute(1, "class", "header");
            __builder.AddAttribute(2, "b-yz907zhuwa");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddAttribute(5, "b-yz907zhuwa");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "header_inner");
            __builder.AddAttribute(8, "b-yz907zhuwa");
            __builder.AddMarkupContent(9, "<div class=\"logo\" b-yz907zhuwa>N<span style=\"color: #0094ff;\" b-yz907zhuwa>K</span>N</div>\r\n            ");
            __builder.OpenElement(10, "nav");
            __builder.AddAttribute(11, "b-yz907zhuwa");
            __builder.AddMarkupContent(12, "<a class=\"nav_link\" href=\"LandingPage.razor#home\" b-yz907zhuwa>Home</a>\r\n                ");
            __builder.AddMarkupContent(13, "<a class=\"nav_link\" href=\"LandingPage.razor#section\" b-yz907zhuwa>About</a>\r\n                ");
            __builder.AddMarkupContent(14, "<a class=\"nav_link\" href=\"/tracks\" b-yz907zhuwa>Tracks</a>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(15);
            __builder.AddAttribute(16, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "<a class=\"nav_link\" href=\"login/logout\" b-yz907zhuwa>Logout</a>");
            }
            ));
            __builder.AddAttribute(18, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "<a class=\"nav_link\" href=\"login/microsoft?RedirectUri=/\" b-yz907zhuwa>Login</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(21, @"<div class=""home"" b-yz907zhuwa><div class=""container"" b-yz907zhuwa><div class=""home_inner"" b-yz907zhuwa><h2 class=""home_suptitle"" b-yz907zhuwa>Musician, Streamer, Polyglot</h2>
            <h1 class=""home_title"" b-yz907zhuwa>NerdyKid<span style=""color: #0094ff;"" b-yz907zhuwa>Nick</span></h1></div>

        <div class=""home_vid"" b-yz907zhuwa><div class=""home_texture"" b-yz907zhuwa></div>
            <video class=""home_video"" autoplay muted loop b-yz907zhuwa><source src=""bg.mp4"" type=""video/mp4"" b-yz907zhuwa></video></div></div></div>



");
            __builder.AddMarkupContent(22, "<section class=\"section\" b-yz907zhuwa><div class=\"container\" b-yz907zhuwa><div class=\"section_header\" b-yz907zhuwa><h1 class=\"section_title\" b-yz907zhuwa>About me</h1>\r\n            <div class=\"section_text\" b-yz907zhuwa><p b-yz907zhuwa>\r\n                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever\r\n                    since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five\r\n                    centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release\r\n                    of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions\r\n                    of Lorem Ipsum.\r\n                </p></div></div>\r\n\r\n        <div class=\"about\" b-yz907zhuwa><a href=\"https://www.twitch.tv/nerdykidnick\" target=\"_blank\" b-yz907zhuwa><div class=\"about_item\" b-yz907zhuwa><div class=\"about_img\" b-yz907zhuwa><img src=\"/social media/twitch.png\" width=\"380\" alt=\"Twitch\" b-yz907zhuwa></div>\r\n                    <div class=\"about_text\" b-yz907zhuwa>Twitch</div></div></a>\r\n            <a href=\"https://twitter.com/NerdyKidNick\" target=\"_blank\" b-yz907zhuwa><div class=\"about_item\" b-yz907zhuwa><div class=\"about_img\" b-yz907zhuwa><img src=\"/social media/twitter.png\" width=\"380\" alt=\"Twitter\" b-yz907zhuwa></div>\r\n                    <div class=\"about_text\" b-yz907zhuwa>Twitter</div></div></a>\r\n            <a href=\"https://www.instagram.com/NerdyKidNick/\" target=\"_blank\" b-yz907zhuwa><div class=\"about_item\" b-yz907zhuwa><div class=\"about_img\" b-yz907zhuwa><img src=\"/social media/instagram.png\" width=\"380\" alt=\"Instagram\" b-yz907zhuwa></div>\r\n                    <div class=\"about_text\" b-yz907zhuwa>Instagram</div></div></a></div></div></section>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "tracks_block");
            __builder.AddAttribute(25, "b-yz907zhuwa");
#nullable restore
#line 103 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
     if (albums != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
         foreach (var item in albums.Items)
        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "tracks_item");
            __builder.AddAttribute(28, "b-yz907zhuwa");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 109 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
                          item.Uri

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "b-yz907zhuwa");
#nullable restore
#line 110 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
                     if (item.Images.Any())
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "img");
            __builder.AddAttribute(33, "class", "tracks_img");
            __builder.AddAttribute(34, "src", 
#nullable restore
#line 112 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
                                                      item.Images[0].Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "alt", "Alternate Text");
            __builder.AddAttribute(36, "b-yz907zhuwa");
            __builder.CloseElement();
#nullable restore
#line 113 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "<img class=\"tracks_img\" src=\"/texture.png\" alt=\"Alternate Text\" b-yz907zhuwa>");
#nullable restore
#line 117 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "tracks_content");
            __builder.AddAttribute(40, "b-yz907zhuwa");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "tracks_name");
            __builder.AddAttribute(43, "b-yz907zhuwa");
            __builder.AddContent(44, 
#nullable restore
#line 119 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
                                                  item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "tracks_year");
            __builder.AddAttribute(48, "b-yz907zhuwa");
            __builder.AddContent(49, 
#nullable restore
#line 120 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
                                                  item.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 124 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
         
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
         for (int i = 0; i < 8; i++)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, @"<div class=""tracks_item"" b-yz907zhuwa><img class=""tracks_img"" src=""/texture.png"" alt=""Alternate Text"" b-yz907zhuwa>
                <div class=""tracks_content"" b-yz907zhuwa><div class=""tracks_name"" b-yz907zhuwa>No spotify autorization.</div>
                    <div class=""tracks_year"" b-yz907zhuwa>Access Token Expired</div></div></div>");
#nullable restore
#line 137 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(52, @"<footer class=""footer"" b-yz907zhuwa><div class=""container"" b-yz907zhuwa><div class=""footer_inner"" b-yz907zhuwa><div class=""footer_block"" b-yz907zhuwa><h4 class=""footer_title"" b-yz907zhuwa>Location</h4>
                <address class=""footer_address"" b-yz907zhuwa><div b-yz907zhuwa>Adresss, 32423, 32423434</div>
                    <div b-yz907zhuwa>234 sdfdsf, 34333LSldsfk</div></address></div>

            <div class=""footer_block"" b-yz907zhuwa><h4 class=""footer_title"" b-yz907zhuwa>About developer</h4>
                <address class=""footer_address"" b-yz907zhuwa><div b-yz907zhuwa>Hi, my name is Artem and it is my first Website.</div>
                    <div b-yz907zhuwa>If you have any questions, feel free to contact with me via discord SmAiL#4188</div></address></div></div></div>

    <div class=""copyright"" b-yz907zhuwa><div class=""container"" b-yz907zhuwa><div class=""copyright_text"" b-yz907zhuwa><div b-yz907zhuwa>Copyright (c) 2021 Smail. All rights reserved.</div>
                <div b-yz907zhuwa>Made with love by SmAiL</div></div></div></div></footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 180 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Shared\LandingPage.razor"
       

    private readonly SpotifyBuilder _spotifyClientBuilder;

    private FullArtist artist;

    public Paging<SimpleAlbum> albums { get; set; }

    public LandingPage(){}

    public LandingPage(SpotifyBuilder spotifyClientBuilder)
    {
        builder = spotifyClientBuilder;
    }

    protected override async Task OnInitializedAsync()
    {
        var spotify = builder.BuildClient();

        var albumRequest = new ArtistsAlbumsRequest
        {
            Limit = 8
        };

        albums = await spotify.Result.Artists.GetAlbums(Constants.ARTIST_ID, albumRequest);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SpotifyBuilder builder { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISpotifySettings settings { get; set; }
    }
}
#pragma warning restore 1591
