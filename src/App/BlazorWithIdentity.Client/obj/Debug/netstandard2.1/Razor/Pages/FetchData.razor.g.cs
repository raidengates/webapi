#pragma checksum "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe582c796be932535292295239407614644b4f1"
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
#line 2 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
using Blazor.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "l-container");
            builder.AddMarkupContent(2, "\r\n");
            builder.AddMarkupContent(3, "<h1>Weather forecast</h1>\r\n\r\n");
            builder.AddMarkupContent(4, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
#line 11 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
            builder.AddContent(5, "    ");
            builder.AddMarkupContent(6, "<p><em>Loading...</em></p>\r\n");
#line 14 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
            builder.AddContent(7, "    ");
            builder.OpenElement(8, "table");
            builder.AddAttribute(9, "class", "table");
            builder.AddMarkupContent(10, "\r\n        ");
            builder.AddMarkupContent(11, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            builder.OpenElement(12, "tbody");
            builder.AddMarkupContent(13, "\r\n");
#line 27 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
            builder.AddContent(14, "                ");
            builder.OpenElement(15, "tr");
            builder.AddMarkupContent(16, "\r\n                    ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, 
#line 30 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(19, "\r\n                    ");
            builder.OpenElement(20, "td");
            builder.AddContent(21, 
#line 31 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(22, "\r\n                    ");
            builder.OpenElement(23, "td");
            builder.AddContent(24, 
#line 32 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n                    ");
            builder.OpenElement(26, "td");
            builder.AddContent(27, 
#line 33 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(28, "\r\n                ");
            builder.CloseElement();
            builder.AddMarkupContent(29, "\r\n");
#line 35 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
            }

#line default
#line hidden
            builder.AddContent(30, "        ");
            builder.CloseElement();
            builder.AddMarkupContent(31, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(32, "\r\n");
#line 38 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
}

#line default
#line hidden
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 40 "D:\workspace\webapi\src\App\BlazorWithIdentity.Client\Pages\FetchData.razor"
            
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("api/SampleData/WeatherForecasts");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591