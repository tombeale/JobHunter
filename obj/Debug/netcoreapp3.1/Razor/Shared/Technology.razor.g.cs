#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb4052de41d3ff51bde95b0957d50f282bbc64c"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
    public partial class Technology : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddAttribute(3, "class", "nobreak");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenComponent<JobHunter.Shared.TextField>(5);
            __builder.AddAttribute(6, "Caption", "Name");
            __builder.AddAttribute(7, "Edit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                          Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Field", "Name");
            __builder.AddAttribute(9, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 9 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                           Index

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Style", "width: 240px;");
            __builder.AddAttribute(11, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 11 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                                      HandleTechnologyChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                           Language.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenComponent<JobHunter.Shared.TextField>(14);
            __builder.AddAttribute(15, "Caption", "Key");
            __builder.AddAttribute(16, "Edit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                          Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Field", "Key");
            __builder.AddAttribute(18, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 15 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                           Index

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Style", "width: 140px;");
            __builder.AddAttribute(20, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 17 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                                      HandleTechnologyChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                           Language.Key

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "class", "nobreak right-align");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenComponent<JobHunter.Shared.TextField>(27);
            __builder.AddAttribute(28, "Caption", "Since (year)");
            __builder.AddAttribute(29, "Edit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                          Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "Field", "BaseYear");
            __builder.AddAttribute(31, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 23 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                           Index

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "Style", "width: 70px;");
            __builder.AddAttribute(33, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 24 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                                      HandleTechnologyChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                           Language.BaseYear.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "colspan", "2");
            __builder.AddAttribute(42, "style", "padding: 2px 4px 20px 53px;");
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 30 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
         if (Edit)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "            ");
            __builder.OpenElement(45, "textarea");
            __builder.AddAttribute(46, "class", "form-control inset");
            __builder.AddAttribute(47, "style", "height: 124px;");
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                                 e => HandleTechnologyChange($"Text|{e.Value.ToString()}")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", 
#nullable restore
#line 34 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                              Language.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 35 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, 
#nullable restore
#line 38 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
             Language.Text

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 38 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
                          
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.AddMarkupContent(55, "<tr>\r\n</tr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Technology.razor"
       
    [Parameter]
    public int Index { get; set; }

    [Parameter]
    public BlueSite.Data.Entities.LanguageEntry Language { get; set; }

    [Parameter]
    public bool Edit { get; set; }

    [Parameter]
    public EventCallback<string> OnChangeCallback { get; set; }


    string Years = "";
    bool DisplayYears = true;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        int Year = DateTime.Now.Year;
        if (Language.BaseYear > 1990)
        {
            int years = Year - Language.BaseYear;
            Years = years.ToString();
            if (years == 0)
            {
                Years = $"< 1 Years";
            }
            else if (years == 1)
            {
                Years = $"{Years} Year";
            }
            else
            {
                Years = $"{Years} Years";
            }
            if (Language.IsEstimate) Years = $"~ {Years}";
        }
        else
        {
            DisplayYears = false;
        }
    }

    public async void HandleTechnologyChange(string value)
    {
        string[] args = value.Split("|");
        if (args.Length > 1)
        {
            switch (args[0].ToLower())
            {
                case "name":
                    Language.Name = args[1];
                    break;
                case "key":
                    Language.Key = args[1];
                    break;
                case "baseyear":
                    Language.BaseYear = Convert.ToInt32(args[1]);
                    break;
                case "text":
                    Language.Text = args[1];
                    break;
            }
            if (Language.LanguageEntryId == 0)
            {
                if (Language.IsValid())
                {
                    _context.LanguageEntries.Add(Language);
                    _context.SaveChanges();
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(Language.Name))
                {
                    _context.SaveChanges();
                }
            }
            StateHasChanged();
            await OnChangeCallback.InvokeAsync("");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlueSiteContext _context { get; set; }
    }
}
#pragma warning restore 1591
