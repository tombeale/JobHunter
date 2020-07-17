#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TitleIcons.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70769e0cc454c00c44de79cef0fff699fa26becf"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TitleIcons.razor"
using JobHunter.Models;

#line default
#line hidden
#nullable disable
    public partial class TitleIcons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TitleIcons.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string IconWidth { get; set; }

    private List<ImgButton> buttons = new List<ImgButton>();


    protected override void OnParametersSet()
    {
        switch (Title.ToLower())
        {
            case "companies":
                buttons.Add(new ImgButton("Add", "CompanyEdit", "Add a company to the list"));
                break;

            case "contacts":
                buttons.Add(new ImgButton("Add", "ContactEdit", "Add a contact to the list"));
                break;
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
