#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fe8c2223cdde27ad7ee12e3991b3fa0d471d814"
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
#line 2 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    public partial class WebLink : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
 if (!String.IsNullOrEmpty(Url))
{
    switch (option)
    {
        case "icon":

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "            ");
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "class", "link");
            __builder.AddMarkupContent(3, "\r\n                ");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
                               (() => GoToWeblink(linkUrl))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "src", "images/icons/" + (
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
                                                                                Image

#line default
#line hidden
#nullable disable
            ) + "-0.png");
            __builder.AddAttribute(7, "width", 
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
                                                                                                     Size

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "title", 
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
                                                                                                                   linkUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "onmouseover", "setIconImage(this," + " \'" + (
#nullable restore
#line 11 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
                                                       Image

#line default
#line hidden
#nullable disable
            ) + "-1.png\')");
            __builder.AddAttribute(10, "onmouseout", "setIconImage(this," + " \'" + (
#nullable restore
#line 12 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
                                                      Image

#line default
#line hidden
#nullable disable
            ) + "-0.png\')");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 14 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
            break;
        default:

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", 
#nullable restore
#line 16 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
                      linkUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "target", "_new");
            __builder.AddContent(17, 
#nullable restore
#line 16 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
                                              linkText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 17 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
            break;
    }


}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "    &nbsp;\r\n");
#nullable restore
#line 25 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\WebLink.razor"
       
    [Parameter]
    public string Url { get; set; }

    [Parameter]
    public string option { get; set; } = "";

    [Parameter]
    public string Size { get; set; } = "28";

    string Image = "WWW";

    string[] link;
    string linkText;
    string linkUrl;

    protected async void GoToWeblink(string url)
    {
        try {
            await JsRuntime.InvokeVoidAsync("open", url, "_blank");

        }
        catch(Exception e)
        {
            Debug.WriteLine(e.ToString());
        }
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (Url != null)
        {
            link = Url.Split("://");
            if (link.Length > 1)
            {
                linkUrl = $"{link[0]}://{link[1]}";
                linkText = link[1];
            }
            else
            {
                linkUrl = $"http://{link[0]}";
                linkText = link[0];
            }

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591