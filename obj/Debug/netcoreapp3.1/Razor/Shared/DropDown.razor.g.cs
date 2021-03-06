#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ebb2fdd743778381df15befd9602c5ed97031b4"
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
            __builder.OpenElement(0, "select");
            __builder.AddAttribute(1, "class", "form-control dropdown");
            __builder.AddAttribute(2, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor"
                                                 (eventArgs => OnClickCallback.InvokeAsync(eventArgs.Value.ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor"
     foreach (var o in Options) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", 
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor"
                        o.Key

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, 
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor"
                                o.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\DropDown.razor"
       
    List<DDOption> Options = new List<DDOption>();

    [Parameter]
    public string OptionSet { get; set; }

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    [Parameter]
    public List<DDOption> Data { get; set; }



    protected override void OnInitialized()
    {
        foreach (var dd in Data)
        {
            Options.Add(new DDOption(dd.Key, dd.Value));
        }
    }





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
