#pragma checksum "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30676a5c432b0eb143b277c81f1b67796192dd02"
// <auto-generated/>
#pragma warning disable 1591
namespace Silvester.Pathfinder.Official.Web
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Fluxor.Blazor.Web.StoreInitializer>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(8);
            __builder.AddAttribute(9, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 7 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(11);
                __builder2.AddAttribute(12, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 9 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 9 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(14, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(15);
                __builder2.AddAttribute(16, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 12 "C:\Personal\Workspaces\github\silvester-io-pathfinder\pathfinder-official-web\Sources\Silvester.Pathfinder.Official.Web\Silvester.Pathfinder.Official.Web\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "<p>Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
