#pragma checksum "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2345035c42f0abc9ac0da6f6ef42f57389a3cd04"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
using Client.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
using Client.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Register</h2>\n");
            __builder.AddMarkupContent(1, "<h3> IF you want to access Add Adult you have to be Male so you need to put M in \"Sex\" field</h3>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "class", "adult-form");
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
                                     newUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
                                                              HandleRegister

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<p>Username</p>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "Enter username");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
                                                     newUser.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.Username = __value, newUser.Username))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.Username));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<p>City</p>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "placeholder", "Enter city");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
                                                     newUser.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.City = __value, newUser.City))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.City));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<p>Sex</p>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "placeholder", "M or F");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
                                                     newUser.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.Sex = __value, newUser.Sex))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<p>Password</p>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "type", "password");
                __builder2.AddAttribute(47, "placeholder", "Enter password");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
                                                     newUser.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.Password = __value, newUser.Password))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 35 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
      
        // prevent error message from moving inputs
        if (errorMessage == null || errorMessage.Equals(""))
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(51, "<div class=\"error-message\">&nbsp;</div>");
#nullable restore
#line 40 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "error-message");
                __builder2.AddContent(54, 
#nullable restore
#line 43 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
                                        errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 44 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
        }
    

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(55, "<button type=\"submit\" class=\"btn btn-success\">Register</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "/Users/peter/RiderProjects/ServerDNP/Client/Pages/Register.razor"
       
    private string errorMessage;
    private User newUser = new User();

    private async Task HandleRegister()
    {
        await Task.Run(async () =>
        {
            errorMessage = "";
            try
            {
                await UserData.Add(newUser);
                ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(newUser.Username, newUser.Password);
                NavigationManager.NavigateTo("/");
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        });
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData UserData { get; set; }
    }
}
#pragma warning restore 1591
