#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0945b93e1558b58aef7dad76469cb70e8af764a6"
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
using JobHunter.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
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
#line 9 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
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
#line 12 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
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
#line 15 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                HandleSetActionType

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<JobHunter.Models.DDOption>>(
#nullable restore
#line 15 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                            Options

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                             ActionType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Style", "width:120px;");
            __builder.AddAttribute(26, "First", "*|All");
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "to-do");
            __builder.AddAttribute(31, "border", "0");
            __builder.AddAttribute(32, "style", "width: 100%");
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.AddMarkupContent(34, @"<tr class=""action-header"">
        <th class=""column-action-status"">Status</th>
        <th class=""column-action-name"">Name</th>
        <th class=""column-action-type"">Type</th>
        <th class=""column-action-date"">Start</th>
        <th class=""column-action-date"">End</th>
    </tr>
");
#nullable restore
#line 25 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
     for (int i = 0; i < actions.Count; i++)
    {
        int index = i;
        ActionItem action = actions[index];
        if (!Utilities.GetDoneFromStatus(action) || !hideDone)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.OpenComponent<JobHunter.Shared.ActionRow>(36);
            __builder.AddAttribute(37, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                               index.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "Action", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlueSite.Data.Entities.ActionItem>(
#nullable restore
#line 31 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                          actions[index]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "Statuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<JobHunter.Models.DDOption>>(
#nullable restore
#line 31 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                                     Statuses

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "Types", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<JobHunter.Models.DDOption>>(
#nullable restore
#line 31 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                                                      Options

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 32 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                          HandleActionChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(42, "OnRowOptionCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 32 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                                    HandleRowOptionClick

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 33 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.OpenElement(45, "tr");
            __builder.AddAttribute(46, "class", "to-do");
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.AddMarkupContent(48, "<td width=\"40\" class=\"right-align\">Add:</td>\r\n        ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "width", "100%");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "class", "form-control to-do inset");
            __builder.AddAttribute(55, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 39 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                  e => handleNewActionKeypress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                           newAction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAction = __value, newAction));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n\r\n");
            __builder.OpenComponent<JobHunter.Shared.Overlay>(62);
            __builder.AddComponentReferenceCapture(63, (__value) => {
#nullable restore
#line 45 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
               overlay = (JobHunter.Shared.Overlay)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.OpenComponent<JobHunter.Shared.ActionStatus>(65);
            __builder.AddAttribute(66, "Statuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<JobHunter.Models.DDOption>>(
#nullable restore
#line 46 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                             Statuses

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 46 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                          HandleSetActionStatus

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(68, (__value) => {
#nullable restore
#line 46 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                    actionStatus = (JobHunter.Shared.ActionStatus)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.OpenComponent<BlueSite.Components.Confirm>(70);
            __builder.AddAttribute(71, "Title", "Confirm Delete Done Items");
            __builder.AddAttribute(72, "Message", "Yes, if you select continue, all the items marked as done will be removed (You can\'t get them back)");
            __builder.AddAttribute(73, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 48 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                           HandleDialogSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(74, (__value) => {
#nullable restore
#line 47 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
               confirm = (BlueSite.Components.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.OpenComponent<JobHunter.Shared.NoteEdit>(76);
            __builder.AddAttribute(77, "overlay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<JobHunter.Shared.Overlay>(
#nullable restore
#line 49 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                    overlay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "OnChangeCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 49 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                HandleNoteSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(79, "NoteId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
                                                                                       -1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(80, (__value) => {
#nullable restore
#line 49 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Actions.razor"
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
