#pragma checksum "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff99f2695b561e0ae835d9d7bb0962e614a7de58"
// <auto-generated/>
#pragma warning disable 1591
namespace Silvester.Pathfinder.Official.Web.Pages.Details
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using Silvester.Pathfinder.Official.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using Silvester.Pathfinder.Official.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\_Imports.razor"
using Fluxor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
using Silvester.Pathfinder.Official.Web.Pages.Details;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/feats")]
    public partial class Feats : BaseDetailsPage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Feats!</h1>\r\n\r\n");
            __Blazor.Silvester.Pathfinder.Official.Web.Pages.Details.Feats.TypeInference.CreateMudTable_0(__builder, 1, 2, "margin: 20px;", 3, 
#nullable restore
#line 8 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                              new Func<TableState, Task<TableData<Feat>>>(GetFeatPage)

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 8 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 8 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
            , 6, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(7);
                __builder2.AddAttribute(8, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Periodic Elements");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudToolBarSpacer>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTextField<string>>(14);
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 12 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                 text => OnSearch(text)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(16, "Placeholder", "Search");
                __builder2.AddAttribute(17, "Adornment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Adornment>(
#nullable restore
#line 12 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                                                                          Adornment.Start

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "AdornmentIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                                                                                                           Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 12 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                                                                                                                                                   Size.Medium

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Class", "mt-0");
                __builder2.CloseComponent();
            }
            , 21, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Feat>>(24);
                    __builder3.AddAttribute(25, "SortLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                              nameof(Feat.Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(27, "Name");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(29);
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Feat>>(31);
                    __builder3.AddAttribute(32, "SortLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                              nameof(Feat.Relearnable)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(34, "Relearnable");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(36);
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Feat>>(38);
                    __builder3.AddAttribute(39, "SortLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                              nameof(Feat.Level)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(41, "Level");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Feat>>(45);
                    __builder3.AddAttribute(46, "SortLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                              nameof(Feat.Description)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(48, "Description");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 49, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(50);
                __builder2.AddAttribute(51, "DataLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                           nameof(Feat.Name)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, 
#nullable restore
#line 21 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                               context.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(55);
                __builder2.AddAttribute(56, "DataLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                           nameof(Feat.Relearnable)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(58, 
#nullable restore
#line 22 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                      context.Relearnable

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(60);
                __builder2.AddAttribute(61, "DataLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                           nameof(Feat.Level)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(63, 
#nullable restore
#line 23 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                context.Level

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(65);
                __builder2.AddAttribute(66, "DataLabel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                           nameof(Feat.Description)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(68, "div");
                    __builder3.AddContent(69, 
#nullable restore
#line 24 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                           context.Description

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            , 70, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(71);
                __builder2.CloseComponent();
            }
            , 72, (__value) => {
#nullable restore
#line 8 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\Pages\Details\Feats.razor"
                                                                                                                                         Table = __value;

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Silvester.Pathfinder.Official.Web.Pages.Details.Feats
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Func<global::MudBlazor.TableState, global::System.Threading.Tasks.Task<global::MudBlazor.TableData<T>>> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7, int __seq8, global::System.Action<global::MudBlazor.MudTable<T>> __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Style", __arg0);
        __builder.AddAttribute(__seq1, "ServerData", __arg1);
        __builder.AddAttribute(__seq2, "Dense", __arg2);
        __builder.AddAttribute(__seq3, "Hover", __arg3);
        __builder.AddAttribute(__seq4, "ToolBarContent", __arg4);
        __builder.AddAttribute(__seq5, "HeaderContent", __arg5);
        __builder.AddAttribute(__seq6, "RowTemplate", __arg6);
        __builder.AddAttribute(__seq7, "PagerContent", __arg7);
        __builder.AddComponentReferenceCapture(__seq8, (__value) => { __arg8((global::MudBlazor.MudTable<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
