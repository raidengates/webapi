#pragma checksum "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0eb1d8ee51660c4a1a27019432def90981ebfe5"
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
#line 15 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#line 1 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Blazor.Services;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 32 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Shared\NavMenu.razor"
            
    [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }
    protected override async Task OnParametersSetAsync()
    {
        //if (!(await AuthenticationState).User.Identity.IsAuthenticated)
        //{
        //    urihelper.NavigateTo("/login");
        //}
    }

    async Task Event_Logout()
    {
        await state.Logout();
        urihelper.NavigateTo("/login");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityAuthenticationState state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper urihelper { get; set; }
    }
}
#pragma warning restore 1591
