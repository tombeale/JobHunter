#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff6ba7aa1126c0646220d4a2fdf6965781a0db3d"
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
    public partial class TextField : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
 if (Show)
{
    if (!Edit)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "inline-flex");
            __builder.OpenElement(3, "label");
            __builder.AddAttribute(4, "class", "form-label");
            __builder.AddContent(5, 
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                            Caption

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "inline-flex field-value right-align form-text");
            __builder.AddAttribute(9, "style", 
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                                           Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, 
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                                                   Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 7 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "inline-flex");
            __builder.OpenElement(15, "label");
            __builder.AddAttribute(16, "class", "form-label");
            __builder.AddContent(17, 
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                            Caption

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "inline-flex field-value");
            __builder.AddAttribute(21, "style", 
#nullable restore
#line 11 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                     Style

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 12 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
             if (TextArea)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "textarea");
            __builder.AddAttribute(25, "class", "form-control inset");
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                                (e => HandleFieldChange(Field, e.Value.ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "style", "height:" + " 124px;" + (
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                                                                                                           BoldStyle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                                                                                                                              Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 15 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "style", 
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                           BoldStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "form-control inset");
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                                                            (e => HandleFieldChange(Field, e.Value.ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "value", 
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                                                                                                                                         Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 19 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 21 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
    }
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.AddMarkupContent(41, "<td><label class=\"form-label\"></label></td>\r\n    ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "class", "field-value");
            __builder.AddAttribute(44, "style", 
#nullable restore
#line 26 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
                                    Style

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 27 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TextField.razor"
       
    [Parameter]
    public string Caption { get; set; }

    [Parameter]
    public string Field { get; set; }

    [Parameter]
    public int? Index { get; set; }

    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public string Style { get; set; } = "";

    [Parameter]
    public string ColSpan { get; set; } = "1";

    [Parameter]
    public bool Edit { get; set; } = false;

    [Parameter]
    public bool Bold { get; set; } = false;

    [Parameter]
    public bool Show { get; set; } = true;

    [Parameter]
    public bool TextArea { get; set; } = false;

    [Parameter]
    public EventCallback<string> OnChangeCallback { get; set; }

    string BoldStyle = "";

    public async void HandleFieldChange(string field, string value)
    {
        await OnChangeCallback.InvokeAsync($"{field}|{value}");
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (Bold) BoldStyle="font-weight: bold;";

    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591