#pragma checksum "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a3173c0758471511e1c32e7e23086ba42f00812"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Client.Shared
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
#line 12 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#line 14 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 22 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Shared\MainLayout.razor"
           

    [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        if (!(await AuthenticationState).User.Identity.IsAuthenticated)
        {
            uriHelper.NavigateTo("/login");
        }
    }

    async Task LogoutClick()
    {
        await state.Logout();
        uriHelper.NavigateTo("/login");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationState state { get; set; }
    }
}
#pragma warning restore 1591
