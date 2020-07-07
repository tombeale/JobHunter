#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0156360383e5b0abc9efc9c20ebb88ff6ab86eed"
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
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
using JobHunter.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
using BlueSite.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actions")]
    public partial class Actions : ActionsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<JobHunter.Shared.SideBar>(0);
            __builder.AddAttribute(1, "MenuSet", "todolist");
            __builder.AddAttribute(2, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 8 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                              HandleSidebarOption

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "d-inline-block");
            __builder.AddAttribute(6, "style", "width:70%");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "h1");
            __builder.AddContent(9, "Action Items ");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", "normal");
            __builder.AddContent(12, "(");
            __builder.AddContent(13, 
#nullable restore
#line 11 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                            actions.Count(action => !action.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " Active Items)");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "d-inline-block");
            __builder.AddAttribute(19, "style", "width:28%; text-align: right;");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenComponent<JobHunter.Shared.DropDown>(21);
            __builder.AddAttribute(22, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                HandleSetActionType

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<JobHunter.Models.DDOption>>(
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                            Options

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                             ActionType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Style", "width:120px;");
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenElement(28, "table");
            __builder.AddAttribute(29, "class", "to-do");
            __builder.AddAttribute(30, "border", "0");
            __builder.AddAttribute(31, "style", "width: 100%");
            __builder.AddMarkupContent(32, "\r\n\r\n");
#nullable restore
#line 18 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
     for (int i = 0; i < actions.Count; i++)
    {
        int index = i;
        ActionItem action = actions[index];
        if (!action.IsDone || !hideDone)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "            ");
            __builder.OpenComponent<JobHunter.Shared.ActionRow>(34);
            __builder.AddAttribute(35, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                               index.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "Action", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlueSite.Data.Entities.ActionItem>(
#nullable restore
#line 24 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                          actions[index]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 24 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                                             HandleActionChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(38, "OnRowOptionCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 24 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                                                                                       HandleRowOptionClick

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 25 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.OpenElement(41, "tr");
            __builder.AddAttribute(42, "class", "to-do");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.AddMarkupContent(44, "<td width=\"40\">&nbsp;</td>\r\n        ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "width", "100%");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "class", "form-control to-do");
            __builder.AddAttribute(51, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 31 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                  e => handleNewActionKeypress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                           newAction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAction = __value, newAction));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n\r\n");
            __builder.OpenComponent<JobHunter.Shared.Overlay>(58);
            __builder.AddComponentReferenceCapture(59, (__value) => {
#nullable restore
#line 37 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
               overlay = (JobHunter.Shared.Overlay)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.OpenComponent<BlueSite.Components.Confirm>(61);
            __builder.AddAttribute(62, "Title", "Confirm Delete Done Items");
            __builder.AddAttribute(63, "Message", "Yes, if you select continue, all the items marked as done will be removed (You can\'t get them back)");
            __builder.AddAttribute(64, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 39 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                           HandleDialogSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(65, (__value) => {
#nullable restore
#line 38 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
               confirm = (BlueSite.Components.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.OpenComponent<JobHunter.Shared.NoteEdit>(67);
            __builder.AddAttribute(68, "overlay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<JobHunter.Shared.Overlay>(
#nullable restore
#line 40 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                    overlay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 40 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                HandleNoteSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(70, "NoteId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                                       -1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(71, (__value) => {
#nullable restore
#line 40 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                noteEdit = (JobHunter.Shared.NoteEdit)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
