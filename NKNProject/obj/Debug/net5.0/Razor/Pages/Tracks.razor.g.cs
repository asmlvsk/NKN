#pragma checksum "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b7e3e385be5db2f63c839472a7516f5e0b8cd2f"
// <auto-generated/>
#pragma warning disable 1591
namespace NKNProject.Pages
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
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\NKNProject\NKNProject\_Imports.razor"
using NKNProject.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tracks")]
    public partial class Tracks : TracksModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatButton>(0);
            __builder.AddAttribute(1, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                                       e => OpenDialog(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Add Track");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __Blazor.NKNProject.Pages.Tracks.TypeInference.CreateMatTable_0(__builder, 6, 7, 
#nullable restore
#line 7 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                  trackList

#line default
#line hidden
#nullable disable
            , 8, "mat-elevation-z5", 9, 
#nullable restore
#line 7 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                                                                      true

#line default
#line hidden
#nullable disable
            , 10, "TrackName", 11, 
#nullable restore
#line 7 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                                                                                                                             SelectionChanged

#line default
#line hidden
#nullable disable
            , 12, (__builder2) => {
                __builder2.AddMarkupContent(13, "<th>Name</th>\r\n        ");
                __builder2.AddMarkupContent(14, "<th>Genre</th>\r\n        ");
                __builder2.AddMarkupContent(15, "<th>Release Date</th>\r\n        ");
                __builder2.AddMarkupContent(16, "<th>Track Description</th>");
            }
            , 17, (context) => (__builder2) => {
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#nullable restore
#line 15 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
             context.TrackName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 16 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
             context.TrackGenre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, 
#nullable restore
#line 17 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
             context.TrackReleaseDate.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "td");
                __builder2.AddContent(28, 
#nullable restore
#line 18 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
             context.TrackDescription

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenElement(30, "td");
                __builder2.OpenComponent<MatBlazor.MatButton>(31);
                __builder2.AddAttribute(32, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                                                 e => OpenDialog(true)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Icon", "edit");
                __builder2.AddAttribute(35, "title", "Edit Track");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatButton>(37);
                __builder2.AddAttribute(38, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                                                 async () => await DeleteTrack(context.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "Icon", "restore_from_trash");
                __builder2.AddAttribute(41, "title", "Delete Track");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            );
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatDialog>(43);
            __builder.AddAttribute(44, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                          dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(47);
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(49, "Add / Edit Track");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(51);
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.NKNProject.Pages.Tracks.TypeInference.CreateMatTextField_1(__builder3, 53, 54, "Track Name", 55, 
#nullable restore
#line 29 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                                                       track.TrackName

#line default
#line hidden
#nullable disable
                    , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => track.TrackName = __value, track.TrackName)), 57, () => track.TrackName);
                    __builder3.AddMarkupContent(58, "\r\n        ");
                    __Blazor.NKNProject.Pages.Tracks.TypeInference.CreateMatTextField_2(__builder3, 59, 60, "Track Genre", 61, 
#nullable restore
#line 30 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                                                        track.TrackGenre

#line default
#line hidden
#nullable disable
                    , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => track.TrackGenre = __value, track.TrackGenre)), 63, () => track.TrackGenre);
                    __builder3.AddMarkupContent(64, "\r\n        ");
                    __Blazor.NKNProject.Pages.Tracks.TypeInference.CreateMatDatePicker_3(__builder3, 65, 66, "Track Release Date", 67, 
#nullable restore
#line 31 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                                                                track.TrackReleaseDate

#line default
#line hidden
#nullable disable
                    , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => track.TrackReleaseDate = __value, track.TrackReleaseDate)), 69, () => track.TrackReleaseDate);
                    __builder3.AddMarkupContent(70, "\r\n        ");
                    __Blazor.NKNProject.Pages.Tracks.TypeInference.CreateMatTextField_4(__builder3, 71, 72, "Track Description", 73, 
#nullable restore
#line 34 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                                                              track.TrackDescription

#line default
#line hidden
#nullable disable
                    , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => track.TrackDescription = __value, track.TrackDescription)), 75, () => track.TrackDescription);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(77);
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatButton>(79);
                    __builder3.AddAttribute(80, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                            OkClickAsync

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(82, "Add");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(84);
                    __builder3.AddAttribute(85, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Admin\Desktop\NKNProject\NKNProject\Pages\Tracks.razor"
                            CloseModal

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(87, "Close");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.NKNProject.Pages.Tracks
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Action<global::System.Object> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg6)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "AllowSelection", __arg2);
        __builder.AddAttribute(__seq3, "FilterByColumnName", __arg3);
        __builder.AddAttribute(__seq4, "SelectionChanged", __arg4);
        __builder.AddAttribute(__seq5, "MatTableHeader", __arg5);
        __builder.AddAttribute(__seq6, "MatTableRow", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591