#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5eb4654dd151d39ae1f48509ae1534db2ce3289"
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
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Index.razor"
using JobHunter.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<JobHunter.Shared.SideBar>(0);
            __builder.AddAttribute(1, "MenuSet", "home");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, "<h1>Welcome to BlueSite</h1>\r\n\r\n");
            __builder.OpenComponent<JobHunter.Shared.Card>(4);
            __builder.AddAttribute(5, "id", "card-1");
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<JobHunter.Pages.Counter>(7);
            __builder.AddAttribute(8, "IncrementAmount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Index.razor"
                          25

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-success");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Index.razor"
                                          (() => SetTitle("From Button"))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Set Title");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Pages\Index.razor"
       
    private int ButtonCount = 5;

    List<string> EventType = new List<string>();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        EventType.Add("OnAfterRenderAsync is called");
        await SetTitle("..Welcome to the Job Hunt");
    }

    async Task SetTitle(string title)
    {
        await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
            title);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
