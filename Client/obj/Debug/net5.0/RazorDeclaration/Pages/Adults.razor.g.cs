// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/peterblasko/RiderProjects/ServerDNP/Client/_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/peterblasko/RiderProjects/ServerDNP/Client/Pages/Adults.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/peterblasko/RiderProjects/ServerDNP/Client/Pages/Adults.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/peterblasko/RiderProjects/ServerDNP/Client/Pages/Adults.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Add")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/peterblasko/RiderProjects/ServerDNP/Client/Pages/Adults.razor"
       


    private void AddNewAdult()
    {
        AdultData.Add(newAdultItem);
        NavigationManager.NavigateTo("/list");
    }

    private readonly Adult newAdultItem = new()
    {
        Id = 0,
        Age = 0,
        Height = 0,
        Sex = null,
        Weight = 0,
        EyeColor = null,
        FirstName = null,
        HairColor = null,
        LastName = null, JobTitle = new Job
        {
            JobTitle = null,
            Salary = 0
        }
    };


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
