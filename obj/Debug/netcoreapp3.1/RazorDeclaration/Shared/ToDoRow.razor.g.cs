#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ToDoRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "812ffb9ce7c9c717ab1f68b3bd95d0ab0c646259"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ToDoRow.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ToDoRow.razor"
using JobHunter.Application;

#line default
#line hidden
#nullable disable
    public partial class ToDoRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ToDoRow.razor"
       
    [Parameter]
    public ActionItem Action { get; set; }

    [Parameter]
    public string Index { get; set; }

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    [Parameter]
    public EventCallback<string> OnChangeCallback { get; set; }

    [Parameter]
    public EventCallback<string> OnRowOptionCallback { get; set; }

    string inputClasses = "form-control to-do";
    string imgSource = "images/checkbox-0.png";

    string Checked = "0";
    bool HasNotes = false;

    private void CaptionChanged(int index, string text)
    {
        Action.Title = text;
        StateHasChanged();
    }

    protected override void OnParametersSet()
    {
        if (Action.IsDone)
        {
            Checked = "1";
            inputClasses = "form-control to-do todo-done";
            imgSource = "images/checkbox-1.png";
        }
        else
        {
            Checked = "0";
            inputClasses = "form-control to-do";
            imgSource = "images/checkbox-0.png";
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
