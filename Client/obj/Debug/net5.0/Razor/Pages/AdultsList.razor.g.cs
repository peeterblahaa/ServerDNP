#pragma checksum "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d11c60fde29fd11b010172453af50710dd193d2"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/peter/RiderProjects/ServerDNP/Client/_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
using Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/list")]
    public partial class AdultsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults List</h3>\n");
            __builder.AddMarkupContent(1, "<p>Filter by:</p>\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "filter-container");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "custom-select filter-property");
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                                                               (arg) => ChangeFilter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "selected");
            __builder.AddAttribute(9, "disabled");
            __builder.AddContent(10, "Select property");
            __builder.CloseElement();
#nullable restore
#line 13 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
         foreach (var value in adultProperties)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "option");
            __builder.AddContent(12, 
#nullable restore
#line 15 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
      
        switch (selectedFilter)
        {
            case "Id":
            case "Age":

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "number");
            __builder.AddAttribute(15, "class", "form-control filter-text-input");
            __builder.AddAttribute(16, "placeholder", "Enter" + " " + (
#nullable restore
#line 24 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                                                                                                selectedFilter.ToLower()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                                                                                                                                       (arg) => Filter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 25 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                break;
            case "First Name":
            case "Last Name":

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control filter-text-input");
            __builder.AddAttribute(21, "placeholder", "Enter" + " " + (
#nullable restore
#line 28 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                                                                                              selectedFilter.ToLower()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 28 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                                                                                                                                     (arg) => Filter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 29 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                break;


        }
    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 37 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p><em>Loading...</em></p>");
#nullable restore
#line 42 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<p><em>No Adults exist. Please add some.</em></p>");
#nullable restore
#line 48 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table");
            __builder.AddMarkupContent(27, @"<thead><tr><th>ID</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Hair Color</th>
            <th>Eye Color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>Job Title</th>
            <th>Salary</th>
            <th>Remove</th></tr></thead>
        ");
            __builder.OpenElement(28, "tbody");
#nullable restore
#line 69 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
         foreach (var item in adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 72 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 73 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 74 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 75 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 76 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 77 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 78 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 79 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 80 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n                ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 81 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                      item.JobTitle== null? "unemployed" : item.JobTitle.JobTitle 

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n              \n\n                ");
            __builder.OpenElement(60, "td");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
                                        () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(63, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 91 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 94 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/AdultsList.razor"
       


    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;
    private string[] adultProperties =  { "Id", "First Name", "Last Name","Age"};
    
    private string selectedFilter;
    


    


    


    protected override async Task OnInitializedAsync()
    {
        allAdults = await AdultsData.GetAdults();
        adultsToShow = allAdults;
        StateHasChanged();
    }

    private void RemoveAdult(int adultId)
    {
        var toRemove = allAdults.First(a => a.Id == adultId);
        allAdults.Remove(toRemove);
        adultsToShow.Remove(toRemove);
        AdultsData.RemoveAdult(toRemove);
    }
    
    
    
    
    private void ChangeFilter(ChangeEventArgs arg)
    {
        selectedFilter = arg.Value.ToString();
        adultsToShow = allAdults;
    }

    private void Filter(ChangeEventArgs arg)
    {
        switch (selectedFilter)
        {
            case "Id":
                int? filterById = null;
                try
                {
                    filterById = int.Parse(arg.Value.ToString());
                }
                catch (Exception e) { Console.WriteLine(e); }
                if (filterById != null)
                {
                    adultsToShow = allAdults.Where(adult => adult.Id == filterById).ToList();
                }
                else adultsToShow = allAdults;
                break;
            case "Age":
                int? filterByAge = null;
                try
                {
                    filterByAge = int.Parse(arg.Value.ToString());
                }
                catch (Exception e) { Console.WriteLine(e); }
                if (filterByAge != null)
                {
                    adultsToShow = allAdults.Where(adult => adult.Age == filterByAge).ToList();
                }
                else adultsToShow = allAdults;
                break;
            
            case "First Name":
                if (arg.Value.ToString() != null)
                {
                    adultsToShow = allAdults.Where(adult => adult.FirstName.Contains(arg.Value.ToString())).ToList();
                }
                else adultsToShow = allAdults;
                break;
            case "Last Name":
                if (arg.Value.ToString() != null)
                {
                    adultsToShow = allAdults.Where(adult => adult.LastName.Contains(arg.Value.ToString())).ToList();
                }
                else adultsToShow = allAdults;
                break;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultsData { get; set; }
    }
}
#pragma warning restore 1591
