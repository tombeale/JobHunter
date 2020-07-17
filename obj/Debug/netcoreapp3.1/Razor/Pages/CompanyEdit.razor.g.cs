#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db953513775fef6a191c35b7ba118cb8a31178e9"
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
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
using JobHunter.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
using JobHunter.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
using BlueSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/companyedit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/companyedit/{id}")]
    public partial class CompanyEdit : CompanyEditBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<JobHunter.Shared.SideBar>(0);
            __builder.AddAttribute(1, "MenuSet", "company");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                  Company

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "d-inline-block");
                __builder2.AddAttribute(10, "style", "width:70%");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "h1");
                __builder2.AddContent(13, "Edit Organization ");
                __builder2.OpenElement(14, "span");
                __builder2.AddAttribute(15, "class", "normal");
                __builder2.AddContent(16, "(Id: #");
                __builder2.AddContent(17, 
#nullable restore
#line 16 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                          Company.CompanyId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(18, ".)");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.AddMarkupContent(21, "<div class=\"d-inline-block\" style=\"width:28%; text-align: right;\">\r\n        <button class=\"btn btn-primary\" style=\"margin-top: 25px;\">Submit</button>\r\n    </div>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(22);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(24);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "container");
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group col-sm-12");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.AddMarkupContent(35, "<label class=\"form-label\" for=\"company-name\">Name</label>\r\n                ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "type", "text");
                __builder2.AddAttribute(38, "id", "company-name");
                __builder2.AddAttribute(39, "class", "form-control bs-input-full bs-title inset");
                __builder2.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                Company.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Company.Name = __value, Company.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "row");
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group col-sm-4");
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenComponent<JobHunter.Shared.ComboBox>(51);
                __builder2.AddAttribute(52, "Caption", "Company Type");
                __builder2.AddAttribute(53, "Id", "company-type");
                __builder2.AddAttribute(54, "HandleEventClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 33 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                                                      HandleCompanyTypeClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                                                                                      Utilities.GetFriendlyDDName(Company.Type, CompanyTypes)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "Width", "225px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group col-sm-4");
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.OpenComponent<JobHunter.Shared.ComboBox>(62);
                __builder2.AddAttribute(63, "Caption", "Interest");
                __builder2.AddAttribute(64, "Id", "company-interest");
                __builder2.AddAttribute(65, "HandleEventClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 36 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                                                      HandleCompanyInterestClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                                                                                          Utilities.GetFriendlyDDName(Company.Interest, CompanyIntrests)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "Width", "225px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.OpenComponent<JobHunter.Shared.SelectListing>(73);
            __builder.AddAttribute(74, "Id", "1");
            __builder.AddAttribute(75, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<JobHunter.Models.DDOption>>(
#nullable restore
#line 51 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                    CompanyTypes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 51 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                                                     HandleSetCompanyType

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(77, "Class", "select select-large");
            __builder.AddAttribute(78, "Width", "220px");
            __builder.AddComponentReferenceCapture(79, (__value) => {
#nullable restore
#line 51 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                            companyTypeList = (JobHunter.Shared.SelectListing)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.OpenComponent<JobHunter.Shared.SelectListing>(81);
            __builder.AddAttribute(82, "Id", "2");
            __builder.AddAttribute(83, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<JobHunter.Models.DDOption>>(
#nullable restore
#line 52 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                        CompanyIntrests

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 52 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                                                                                            HandleSetCompanyInterest

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(85, "Class", "select select-large");
            __builder.AddAttribute(86, "Width", "220px");
            __builder.AddComponentReferenceCapture(87, (__value) => {
#nullable restore
#line 52 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                            companyInterestList = (JobHunter.Shared.SelectListing)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "info");
            __builder.AddContent(91, 
#nullable restore
#line 53 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\CompanyEdit.razor"
                   StatusMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlueSiteContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
