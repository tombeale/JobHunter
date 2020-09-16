#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d83855310429371072f01fb74e52b02a08f3e2b"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor"
using JobHunter.Models;

#line default
#line hidden
#nullable disable
    public partial class DropDown : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor"
       
    List<DDOption> Options = new List<DDOption>();

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    [Parameter]
    public List<DDOption> Data { get; set; }

    [Parameter]
    public string First { get; set; }

    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public string Class { get; set; } = "";

    [Parameter]
    public string Style { get; set; } = "";

    private string sel = "";

    private string Classes = "form-control dropdown";

    protected override void OnInitialized()
    {
        if (First != null)
        {
            string[] opt = First.Split('|');
            Options.Add(new DDOption(opt[0], opt[1]));
        }

        foreach (var dd in Data)
        {
            Options.Add(new DDOption(dd.Key, dd.Value));
        }
    }

    protected override void OnParametersSet()
    {
        if (Class != "") Classes = $"{Classes} {Class}";
    }

    public void Refresh()
    {
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
