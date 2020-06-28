#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0a5817b8acbc016732fe08b813f037f4c5b4f40"
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
            __builder.OpenComponent<JobHunter.Shared.SideBar>(0);
            __builder.AddAttribute(1, "MenuSet", "company");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "h1");
            __builder.AddContent(4, "Company ");
            __builder.AddContent(5, 
#nullable restore
#line 9 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyView.razor"
             company.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.AddMarkupContent(7, "<table class=\"to-do\" border=\"0\" style=\"width: 100%\">\r\n\r\n\r\n</table>");
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
        await SetTitle($"Viewing Company Id #{company.CompanyId}");
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
