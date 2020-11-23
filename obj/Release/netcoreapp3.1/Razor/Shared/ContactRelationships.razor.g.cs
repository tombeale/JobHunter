#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ContactRelationships.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14b31c794344ed14d72cc4cfff896b4705821e91"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ContactRelationships.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
    public partial class ContactRelationships : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "span");
            __builder.AddAttribute(1, "class", "link");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ContactRelationships.razor"
                             LaunchDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", "images/icons/" + (
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ContactRelationships.razor"
                            Image

#line default
#line hidden
#nullable disable
            ) + "-0.png");
            __builder.AddAttribute(6, "width", 
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ContactRelationships.razor"
                                                 Size

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "title", "Add a ");
            __builder.AddAttribute(8, "onmouseover", "setIconImage(this," + " \'" + (
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ContactRelationships.razor"
                                           Image

#line default
#line hidden
#nullable disable
            ) + "-1.png\')");
            __builder.AddAttribute(9, "onmouseout", "setIconImage(this," + " \'" + (
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ContactRelationships.razor"
                                          Image

#line default
#line hidden
#nullable disable
            ) + "-0.png\')");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ContactRelationships.razor"
       

    [Parameter]
    public BsDialog Dialog { get; set; }

    [Parameter]
    public Company Company { get; set; }

    [Parameter]
    public string Size { get; set; } = "28";

    [Parameter]
    public JobHunter.Pages.Companies Parent { get; set; }

    string Image = "Person-add";

    void LaunchDialog()
    {
        Parent.dialog.CompanyId = Company.CompanyId;
        Parent.dialog.Show();
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
