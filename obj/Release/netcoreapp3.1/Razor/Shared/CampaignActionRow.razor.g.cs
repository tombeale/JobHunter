#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b4eb6a419049061d9a22437f94baee910a4cf04"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
using JobHunter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
using JobHunter.Application;

#line default
#line hidden
#nullable disable
    public partial class CampaignActionRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddAttribute(1, "class", "item-row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "td");
            __builder.AddAttribute(4, "class", "item-row nobreak");
            __builder.AddAttribute(5, "style", "width:" + " " + (
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
                                                 Utilities.ColSize(2)

#line default
#line hidden
#nullable disable
            ) + " px;");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddContent(7, 
#nullable restore
#line 7 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
          GetStatusLink(Lookup.GetFriendlyName("status", Action.Status), Action.ActionItemId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "td");
            __builder.AddAttribute(11, "class", "item-row");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
         Action.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "class", "item-row nobreak");
            __builder.AddAttribute(18, "style", "width:" + " " + (
#nullable restore
#line 12 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
                                                 Utilities.ColSize(2)

#line default
#line hidden
#nullable disable
            ) + " px;");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddContent(20, 
#nullable restore
#line 13 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
          GetActionTypeLink(Lookup.GetFriendlyName("actiontype", Action.Type), Action.ActionItemId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "class", "item-row");
            __builder.AddAttribute(25, "style", "width:" + " " + (
#nullable restore
#line 15 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
                                         Utilities.ColSize(2)

#line default
#line hidden
#nullable disable
            ) + " px;");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenComponent<JobHunter.Shared.DateField>(27);
            __builder.AddAttribute(28, "DateValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 16 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
                               Action.StartDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "Option", "dateonly");
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "item-row");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenComponent<JobHunter.Shared.InlineToolBar>(35);
            __builder.AddAttribute(36, "Size", "14");
            __builder.AddAttribute(37, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
                                         Action.ActionItemId.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "MenuSet", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlueSite.Data.Entities.MenuItem>>(
#nullable restore
#line 19 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
                                                                                   ToolBars.GetCampaignViewActionItems(Action?.Notes?.Count > 0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 19 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
                                                                                                                                                                     HandleActionRowOptionClick

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CampaignActionRow.razor"
       
    [Parameter]
    public ActionItem Action { get; set; }

    [Parameter]
    public LookUps Lookup { get; set; }

    [Inject] NavigationManager NavManager { get; set; }

    MarkupString GetStatusLink(string status, int? id)
    {
        MarkupString Status = (MarkupString)status;

        if (id == null) return Status;

        return Status;
    }

    MarkupString GetActionTypeLink(string status, int? id)
    {

        MarkupString Status = (MarkupString)status;

        if (id == null) return Status;

        switch (status.ToLower())
        {
            case "meeting":
            case "preparing":
                Status = (MarkupString)$"<a href='/MeetingPrep/{id}'>{status}</a>";
                break;
        }
        return Status;
    }

    protected void HandleActionRowOptionClick(string value)
    {
        var vals = value.Split('|');
        int actionId = Convert.ToInt32(vals[0]);
        switch (vals[1].ToLower())
        {
            case "edit":
                NavManager.NavigateTo($"actionedit/{actionId}?campaignview/{Action.ActionItemId}");
                break;
            case "note":
            case "note-filled":
                break;
        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
