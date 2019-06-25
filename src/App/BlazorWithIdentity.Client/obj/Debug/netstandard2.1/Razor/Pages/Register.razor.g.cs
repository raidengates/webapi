#pragma checksum "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99dd33efdf32e6b83063eaf81c368c553029d802"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#line 7 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Blazor.Client;

#line default
#line hidden
#line 8 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Blazor.Client.Shared;

#line default
#line hidden
#line 9 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Blazor.Client.Services.Contracts;

#line default
#line hidden
#line 10 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Blazor.Client.Services.Implementations;

#line default
#line hidden
#line 11 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Blazor.Client.States;

#line default
#line hidden
#line 15 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "form");
            builder.AddAttribute(1, "class", "u-center  shadow-sm p-3 mb-5 bg-white rounded form-signin");
            builder.AddAttribute(2, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIEventArgs>(this, 
#line 6 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\Register.razor"
                                                                                    OnSubmit

#line default
#line hidden
            ));
            builder.AddMarkupContent(3, "\r\n    ");
            builder.AddMarkupContent(4, "<h4 class=\"font-weight-normal text-center\">Create Account</h4>\r\n     ");
            builder.OpenElement(5, "div");
            builder.AddAttribute(6, "class", "form-group ");
            builder.AddMarkupContent(7, "\r\n ");
            builder.AddMarkupContent(8, "<label for=\"inputUsername\" class=\"sr-only\">User Name</label>\r\n    ");
            builder.OpenElement(9, "input");
            builder.AddAttribute(10, "id", "inputUsername");
            builder.AddAttribute(11, "class", "form-control");
            builder.AddAttribute(12, "placeholder", "Username");
            builder.AddAttribute(13, "required", true);
            builder.AddAttribute(14, "autofocus", true);
            builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(
#line 11 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\Register.razor"
                               registerParameters.UserName

#line default
#line hidden
            ));
            builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerParameters.UserName = __value, registerParameters.UserName));
            builder.CloseElement();
            builder.AddMarkupContent(17, "\r\n     ");
            builder.CloseElement();
            builder.AddMarkupContent(18, "\r\n   \r\n     ");
            builder.OpenElement(19, "div");
            builder.AddAttribute(20, "class", "form-group ");
            builder.AddMarkupContent(21, "\r\n    ");
            builder.AddMarkupContent(22, "<label for=\"inputPassword\" class=\"sr-only\">Password</label>\r\n    ");
            builder.OpenElement(23, "input");
            builder.AddAttribute(24, "type", "password");
            builder.AddAttribute(25, "id", "inputPassword");
            builder.AddAttribute(26, "class", "form-control");
            builder.AddAttribute(27, "placeholder", "Password");
            builder.AddAttribute(28, "required", true);
            builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(
#line 17 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\Register.razor"
                     registerParameters.Password

#line default
#line hidden
            ));
            builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerParameters.Password = __value, registerParameters.Password));
            builder.CloseElement();
            builder.AddMarkupContent(31, "\r\n     ");
            builder.CloseElement();
            builder.AddMarkupContent(32, "\r\n\r\n ");
            builder.OpenElement(33, "div");
            builder.AddAttribute(34, "class", "form-group ");
            builder.AddMarkupContent(35, "\r\n ");
            builder.AddMarkupContent(36, "<label for=\"inputPasswordConfirm\" class=\"sr-only\">Password Confirmation</label>\r\n    ");
            builder.OpenElement(37, "input");
            builder.AddAttribute(38, "type", "password");
            builder.AddAttribute(39, "id", "inputPasswordConfirm");
            builder.AddAttribute(40, "class", "form-control");
            builder.AddAttribute(41, "placeholder", "Password Confirmation");
            builder.AddAttribute(42, "required", true);
            builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(
#line 23 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\Register.razor"
                                                         registerParameters.PasswordConfirm

#line default
#line hidden
            ));
            builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerParameters.PasswordConfirm = __value, registerParameters.PasswordConfirm));
            builder.CloseElement();
            builder.AddMarkupContent(45, "\r\n ");
            builder.CloseElement();
            builder.AddMarkupContent(46, "\r\n   \r\n\r\n    ");
            builder.AddMarkupContent(47, "<button class=\"btn btn-primary btn-block\" type=\"submit\">Create account</button>\r\n\r\n    ");
            builder.OpenElement(48, "label");
            builder.AddAttribute(49, "class", "text-danger");
            builder.AddContent(50, 
#line 29 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\Register.razor"
                                error

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(51, "\r\n    ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(52);
            builder.AddAttribute(53, "href", "login");
            builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(55, "\r\n        ");
                builder2.AddMarkupContent(56, "<h6 class=\"font-weight-normal text-center\">Already have an account? Click here to login</h6>\r\n    ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(57, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 35 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\Register.razor"
           

    RegisterParameters registerParameters { get; set; } = new RegisterParameters();
    string error { get; set; }

     [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }
        
    protected override async Task OnParametersSetAsync()
    {
        if ((await AuthenticationState).User.Identity.IsAuthenticated)
        {
           uriHelper.NavigateTo("/");
        }
    }

    async Task OnSubmit()
    {
        error = null;
        try
        {
            await state.Register(registerParameters);
            uriHelper.NavigateTo("/");
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationState state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591
