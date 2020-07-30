#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CompanyNoteEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "242048fe7b99153db135adc71ca2fed1d1b3a27f"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CompanyNoteEditor.razor"
using BlueSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CompanyNoteEditor.razor"
using BlueSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CompanyNoteEditor.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CompanyNoteEditor.razor"
using JobHunter.Services;

#line default
#line hidden
#nullable disable
    public partial class CompanyNoteEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\CompanyNoteEditor.razor"
       
    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    [Parameter]
    public string Style { get; set; }

    protected BsDialog notedialog;
    JobHuntRepository Repository;

    protected string Notes { get; set; } = "";

    public Company company { get; set; }

    protected void HandleChange(string value)
    {
        company.Notes = value;
    }

    protected override void OnInitialized()
    {
        Repository = new JobHuntRepository(_context);
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
    }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        return _browser.CenterElement();
    }

    public void Show(int index, Company co)
    {
        company = co;
        Notes = (company.Notes != null) ? company.Notes : "";
        notedialog.Show();
        StateHasChanged();
    }

    public void Hide()
    {
        notedialog.Hide();
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BrowserService _browser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlueSiteContext _context { get; set; }
    }
}
#pragma warning restore 1591
