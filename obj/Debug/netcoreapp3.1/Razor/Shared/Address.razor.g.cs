#pragma checksum "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Address.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f558a6d37ac064474710d971b7b2f25f02af2b19"
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
#line 1 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Address.razor"
using BlueSite.Data.Entities;

#line default
#line hidden
#nullable disable
    public partial class Address : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Address.razor"
 if (!String.IsNullOrEmpty(FormattedAddress))
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Address.razor"
     FormattedAddress

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 5 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Address.razor"
                     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "    &nbsp;\r\n");
#nullable restore
#line 10 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Address.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "F:\Projects\Blazor\JobHunter2020\JobHunter\Shared\Address.razor"
       

    [Parameter]
    public Company Company { get; set; }

    [Parameter]
    public Contact Contact { get; set; }

    [Parameter]
    public string Format { get; set; }

    private string Address1 { get; set; } = "";
    private string Address2 { get; set; } = "";
    private string City     { get; set; } = "";
    private string State    { get; set; } = "";
    private string Zip      { get; set; } = "";

    protected string FormattedAddress;

    private string defaultFormat = "#a1# #a2#, #c#, #s# #z#";

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (Company != null) getAddressFromCompany(Company);
        if (Contact != null) getAddressFromContact(Contact);

        string format = (!String.IsNullOrEmpty(Format)) ? Format : defaultFormat;
        FormattedAddress = ApplyFormat(format);
    }

    string ApplyFormat(string format)
    {
        if (String.IsNullOrEmpty(format)) return "";

        return format.Replace("#a1#", Address1)
                     .Replace("#a2#", Address2)
                     .Replace("#c#",  City)
                     .Replace("#s#",  State)
                     .Replace("#z#",  Zip);

    }

    void getAddressFromCompany(Company company)
    {
        Address1 = (company.Address1 != null) ? company.Address1 : "";
        Address2 = (company.Address2 != null) ? company.Address2 : "";
        City     = (company.City     != null) ? company.City     : "";
        State    = (company.State    != null) ? company.State    : "";
        Zip      = (company.Zip      != null) ? company.Zip      : "";
    }


    void getAddressFromContact(Contact contact)
    {
        Address1 = (contact.Address1 != null) ? contact.Address1 : "";
        Address2 = (contact.Address2 != null) ? contact.Address2 : "";
        City     = (contact.City     != null) ? contact.City     : "";
        State    = (contact.State    != null) ? contact.State    : "";
        Zip      = (contact.Zip      != null) ? contact.Zip      : "";
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591