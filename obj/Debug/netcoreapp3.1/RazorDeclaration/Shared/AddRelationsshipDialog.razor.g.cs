#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\AddRelationsshipDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "876ad9298d2cbeca318e91067ad4dc84e26b129a"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\AddRelationsshipDialog.razor"
using BlueSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\AddRelationsshipDialog.razor"
using BlueSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\AddRelationsshipDialog.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\AddRelationsshipDialog.razor"
using JobHunter.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\AddRelationsshipDialog.razor"
using JobHunter.Services;

#line default
#line hidden
#nullable disable
    public partial class AddRelationsshipDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\AddRelationsshipDialog.razor"
       

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    [Parameter]
    public string Style { get; set; }

    [Parameter]
    public CompaniesBase Parent { get; set; } = null;

    [Parameter]
    public string FromPage { get; set; } = "";

    public int CompanyId { get; set; } = -1;

    protected List<Contact> Contacts { get; set; } = new List<Contact>();

    private ContactEdit contactForm { get; set; }

    BsDialog dialog;
    JobHuntRepository Repository;

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
        // _ = _browser.CenterElement();
        return _browser.CenterElement();
    }

    public void Show()
    {
        contactForm.Clear();
        contactForm.setCompanyId(CompanyId);
        dialog.Show();
        if (CompanyId >= 0)
        {
            Contacts = Repository.GetUnrelatedCompanyContacts(CompanyId);
            StateHasChanged();
        }
    }

    public void Hide()
    {
        dialog.Hide();
        OnClickCallback.InvokeAsync("changed");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BrowserService _browser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlueSiteContext _context { get; set; }
    }
}
#pragma warning restore 1591
