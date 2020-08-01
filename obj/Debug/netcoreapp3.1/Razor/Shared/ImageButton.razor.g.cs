#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ImageButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f7fb7d95c10777aa8cb7a3f595051e58b70c7ba"
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
    public partial class ImageButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "img");
            __builder.AddAttribute(1, "class", "inline-menu link");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ImageButton.razor"
                                      ImageSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onmouseover", "setIconImage(this," + " \'" + (
#nullable restore
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ImageButton.razor"
                                      Image

#line default
#line hidden
#nullable disable
            ) + "-1.png\')");
            __builder.AddAttribute(4, "onmouseout", "setIconImage(this," + " \'" + (
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ImageButton.razor"
                                     Image

#line default
#line hidden
#nullable disable
            ) + "-0.png\')");
            __builder.AddAttribute(5, "src", "images/Icons/" + (
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ImageButton.razor"
                       Image

#line default
#line hidden
#nullable disable
            ) + "-0.png");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ImageButton.razor"
              eventArgs => OnChangeCallback.InvokeAsync($"{Index}|{Image}")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "title", 
#nullable restore
#line 6 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ImageButton.razor"
            ToolTip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\ImageButton.razor"
       
    [Parameter]
    public string Image { get; set; }

    [Parameter]
    public string Index { get; set; }

    [Parameter]
    public string Size { get; set; } = "20";

    [Parameter]
    public string ToolTip { get; set; } = "";

    [Parameter]
    public EventCallback<string> OnChangeCallback { get; set; }

    string ImageSize;

    protected override void OnParametersSet()
    {
        ImageSize = $"{Size}px";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
