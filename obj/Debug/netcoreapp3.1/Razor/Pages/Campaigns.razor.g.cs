#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Campaigns.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6f42a5f5207d41e0301d556251e67e73b2d3c2"
// <auto-generated/>
#pragma warning disable 1591
namespace JobHunter.Pages
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
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Campaigns.razor"
using JobHunter.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Campaigns.razor"
using JobHunter.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Campaigns.razor"
using BlueSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Campaigns.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/campaigns")]
    public partial class Campaigns : CampaignsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<JobHunter.Shared.SideBar>(0);
            __builder.AddAttribute(1, "MenuSet", "companies");
            __builder.AddAttribute(2, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Campaigns.razor"
                                               HandleSidebarOption

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "h1");
            __builder.AddContent(5, "Campaigns");
            __builder.OpenComponent<JobHunter.Shared.TitleIcons>(6);
            __builder.AddAttribute(7, "Title", "Campaigns");
            __builder.AddAttribute(8, "IconWidth", "24px");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n");
#nullable restore
#line 15 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Campaigns.razor"
 if (Campaigns.Count < 1)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.AddMarkupContent(11, "<p>No campaigns found</p>\r\n");
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Campaigns.razor"
}
else
{

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlueSiteContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
