#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\PhoneNumber.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baebfe8015ab8d28be2c28846a9ff7bac28f922d"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\PhoneNumber.razor"
using JobHunter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\PhoneNumber.razor"
using JobHunter.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\PhoneNumber.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
    public partial class PhoneNumber : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\PhoneNumber.razor"
       

    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Caption { get; set; }

    [Parameter]
    public int Index {  get; set; } = -1;

    [Parameter]
    public string Width { get; set; }

    [Parameter]
    public Phone Phone { get; set; }

    [Parameter]
    public List<DDOption> PhoneTypes { get; set; }

    [Parameter]
    public EventCallback HandleEventClick { get; set; }

    protected string PhoneId;

    protected void handleClick()
    {
        Globals.CurrentPhoneIndex = Index;
        HandleEventClick.InvokeAsync("");
    }

    protected string HandlePhoneTypeChange
    {
        get
        {
            return Phone.Type;
        }
        set
        {
            Phone.Type = value;
            StateHasChanged();
        }
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (Phone == null)
        {
            Phone = new Phone("", "main");
        }
        PhoneId = (Index >= 0) ? $"{Id}-{Index.ToString()}" : Id;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
