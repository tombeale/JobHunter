#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Confirm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ea4f203da5d541fa75a051c930a1f58a4ab93e5"
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
    public partial class Confirm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<JobHunter.Shared.BsDialog>(0);
            __builder.AddAttribute(1, "DlgTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Confirm.razor"
                                   Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "DlgMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Confirm.razor"
                                                       Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "DlgOnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Confirm.razor"
                               OnClickCallback

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Buttons", "Cancel:cancel:btn btn-sm btn-secondary bs-dialog,Do It:continue:btn btn-sm btn-primary bs-dialog");
            __builder.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Confirm.razor"
                dialog = (JobHunter.Shared.BsDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Confirm.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Message { get; set; }

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    private BsDialog dialog;


    public void Hide()
    {
        dialog.Hide();
    }

    public void Show()
    {
        dialog.Show();
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
