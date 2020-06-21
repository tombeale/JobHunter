#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a1625862d1c4c5a016e9eeaf1376ecb5fdd76df"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyView.razor"
using JobHunter.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyView.razor"
using BlueSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyView.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/companyview/{id}")]
    public partial class CompanyView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyView.razor"
       
    [Parameter]
    public string Id { get; set; }

    BlueSite.Data.Entities.Company company;
    JobHuntRepository Repository;










    /* *******************************************************************
        Startup Events
     ****************************************************************** */

    protected override void OnInitialized()
    {
        Repository = new JobHuntRepository(_context);


    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        int CompanyId = Convert.ToInt32(Id);
        company = GetCompany(CompanyId);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await SetTitle("Companies");
    }

    async Task SetTitle(string title)
    {
        await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
            title);
    }


    /* *******************************************************************
        Data MEthods
     ****************************************************************** */

    Company GetCompany(int id)
    {
        return Repository.GetCompany(id);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlueSiteContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591