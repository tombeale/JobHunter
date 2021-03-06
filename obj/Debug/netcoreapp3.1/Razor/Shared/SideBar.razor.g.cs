#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\SideBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3e53a6f968c284095cacfc0ce94f8dc96e387cd"
// <auto-generated/>
#pragma warning disable 1591
namespace JobHunter.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\Blazor\JobHunter2020\JobHunter\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\Blazor\JobHunter2020\JobHunter\_Imports.razor"
using JobHunter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Projects\Blazor\JobHunter2020\JobHunter\_Imports.razor"
using JobHunter.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\SideBar.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\SideBar.razor"
using JobHunter.Application;

#line default
#line hidden
#nullable disable
    public partial class SideBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "side-bar");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<p class=\"sidebar-header\">Options</p>\r\n        ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "list-group");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 7 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\SideBar.razor"
             foreach (var item in items)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", "list-group-item sidebar-link");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\SideBar.razor"
                                                                   (() => OnClickCallback.InvokeAsync(item.Action))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, 
#nullable restore
#line 9 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\SideBar.razor"
                                                                                                                      item.Caption

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\SideBar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\SideBar.razor"
       

    private List<MenuItem> items = new List<MenuItem>();
    private SideBar Parent;

    [Parameter]
    public string MenuSet { get; set; }

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    protected override void OnParametersSet()
    {
        items = SideBars.GetMenuSet(MenuSet);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
