#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30c1cf0f3206504cf2150566e45525779ed1eb56"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor"
using BlueSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor"
using JobHunter.Models;

#line default
#line hidden
#nullable disable
    public partial class CampaignSummary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Campaign Stats</h3>\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "nested-section");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddMarkupContent(8, "<td class=\"stat-label\">Total Active:</td>\r\n            ");
            __builder.OpenElement(9, "td");
            __builder.AddAttribute(10, "class", "stat-value");
            __builder.AddContent(11, 
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor"
                                    Stats.Active

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<td class=\"stat-label\">Total Inctive:</td>\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "class", "stat-value");
            __builder.AddContent(16, 
#nullable restore
#line 12 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor"
                                    Stats.Cancelled

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.AddMarkupContent(21, "<td class=\"stat-label\">Not Started:</td>\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "class", "stat-value");
            __builder.AddContent(24, 
#nullable restore
#line 16 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor"
                                    Stats.NotStarted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, "<td class=\"stat-label\">Waiting:</td>\r\n            ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "class", "stat-value");
            __builder.AddContent(29, 
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor"
                                    Stats.Waiting

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.AddMarkupContent(34, "<td class=\"stat-label\">Completed:</td>\r\n            ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "class", "stat-value");
            __builder.AddContent(37, 
#nullable restore
#line 22 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor"
                                    Stats.Completed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignSummary.razor"
       

    [Inject] BlueSiteContext _context { get; set; }

    JobHuntRepository Repository;

    Campaign campaign;

    JobHunter.Models.CampaignStats Stats;

    User _user;

    protected override void OnInitialized()
    {
        Repository = new JobHuntRepository(_context);
        _user = Repository.GetUserFromSignon();

        Stats = new CampaignStats(Repository.AllCampaigns.ToList());


    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
