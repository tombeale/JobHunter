#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TopicEditPoint.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3faff60f240936d4350aebed931c27195b4ad39"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TopicEditPoint.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
    public partial class TopicEditPoint : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\TopicEditPoint.razor"
       

    [Parameter]
    public int Index { get; set; }

    [Parameter]
    public BlueSite.Data.Entities.TopicPoint Point { get; set; }

    [Parameter]
    public EventCallback HandlePointChange { get; set; }

    [Parameter]
    public TopicEditSection Parent { get; set; }

    [Parameter]
    public bool IsNew { get; set; }

    public string ElementId = "";

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (IsNew)
        {
            ElementId = $"topic-point-{Parent.Topic.Id}-{Index}";
        }
        else
        {
            ElementId = $"topic-point-{Parent.Topic.Id}-new";
        }
    }

    async void HandleChange(string value)
    {
        Point.Text = value;
        if (IsNew)
        {
            _context.TopicPoints.Add(new TopicPoint(Point));
            Parent.SetParentRefresh();
        }
        await HandlePointChange.InvokeAsync(value);
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlueSiteContext _context { get; set; }
    }
}
#pragma warning restore 1591