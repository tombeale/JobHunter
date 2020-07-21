#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed378e2eb643951f0f6693114d6996e782eb5d38"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
using JobHunter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
using JobHunter.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class Phones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
 if (Numbers != null && Numbers.Count > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
     for (int i=0; i<Numbers.Count; i++)
    {
        Phone p = Numbers[i];
        string number = Regex.Replace(p.Number, @"[^0-9]", "");
        string type = (PhoneTypes != null) ? Utilities.GetFriendlyDDName(p.Type, PhoneTypes) : p.Type;

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "inline-phone phone-number");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", "tel:" + (
#nullable restore
#line 13 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
                                                             number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, 
#nullable restore
#line 13 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
                                                                      Utilities.FormatPhoneNumber(p.Number)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 13 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
                                                                                                                 ShowExt(p.Ext)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "inline-phone phone-number-type");
            __builder.AddContent(11, 
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
                                                     type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 15 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
         if (i < count)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "            <br>\r\n");
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.AddMarkupContent(15, "<div class=\"inline phone-number\">&nbsp;</div>\r\n");
#nullable restore
#line 24 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Phones.razor"
       
    [Parameter]
    public List<Phone> Numbers { get; set; }

    [Parameter]
    public List<DDOption> PhoneTypes { get; set; }

    int count = 0;

    string ShowExt(string ext)
    {
        return (String.IsNullOrEmpty(ext)) ? "" : $" x{ext}";
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        count = (Numbers != null) ? Numbers.Count -1 : 0;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
