#pragma checksum "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "709d70eadb0e1d008cdc9be167d49fa340affc09"
// <auto-generated/>
#pragma warning disable 1591
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
    public class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            builder.AddAttribute(2, "role", "alert");
            builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            builder.OpenElement(4, "strong");
            builder.AddContent(5, 
#line 3 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Shared\SurveyPrompt.razor"
             Title

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(6, "\r\n\r\n    ");
            builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2077509\">brief survey</a>\r\n    </span>\r\n    and tell us what you think.\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Shared\SurveyPrompt.razor"
            
    // Demonstrates how a parent component can supply parameters
    [Parameter] string Title { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
