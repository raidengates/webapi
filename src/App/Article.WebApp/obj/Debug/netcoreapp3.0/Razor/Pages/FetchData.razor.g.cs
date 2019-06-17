#pragma checksum "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18080a3a92c8a712afea9345c389298ccf8d0826"
// <auto-generated/>
#pragma warning disable 1591
namespace Article.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Workspace\webAPI\src\App\Article.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Workspace\webAPI\src\App\Article.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Workspace\webAPI\src\App\Article.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "D:\Workspace\webAPI\src\App\Article.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\Workspace\webAPI\src\App\Article.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Workspace\webAPI\src\App\Article.WebApp\_Imports.razor"
using Article.WebApp.Shared;

#line default
#line hidden
#line 7 "D:\Workspace\webAPI\src\App\Article.WebApp\_Imports.razor"
using Blazorise;

#line default
#line hidden
#line 2 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
using Article.WebApp.Data;

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
            builder.AddMarkupContent(2, "\r\n    ");
            builder.AddMarkupContent(3, "<h1>Weather forecast</h1>\r\n    ");
            builder.AddMarkupContent(4, "<p>This component demonstrates fetching data from a service.</p>\r\n");
#line 10 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
     if (forecasts == null)
    {

#line default
#line hidden
            builder.AddContent(5, "        ");
            builder.AddMarkupContent(6, "<p><em>Loading...</em></p>\r\n");
#line 13 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
    }
    else
    {

#line default
#line hidden
            builder.AddContent(7, "        ");
            builder.OpenElement(8, "table");
            builder.AddAttribute(9, "class", "table");
            builder.AddMarkupContent(10, "\r\n            ");
            builder.AddMarkupContent(11, "<thead>\r\n                <tr>\r\n                    <th>Date</th>\r\n                    <th>Temp. (C)</th>\r\n                    <th>Temp. (F)</th>\r\n                    <th>Summary</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            builder.OpenElement(12, "tbody");
            builder.AddMarkupContent(13, "\r\n");
#line 26 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
                 foreach (var forecast in forecasts)
                {

#line default
#line hidden
            builder.AddContent(14, "                    ");
            builder.OpenElement(15, "tr");
            builder.AddMarkupContent(16, "\r\n                        ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, 
#line 29 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
                             forecast.Date.ToShortDateString()

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(19, "\r\n                        ");
            builder.OpenElement(20, "td");
            builder.AddContent(21, 
#line 30 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
                             forecast.TemperatureC

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(22, "\r\n                        ");
            builder.OpenElement(23, "td");
            builder.AddContent(24, 
#line 31 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
                             forecast.TemperatureF

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n                        ");
            builder.OpenElement(26, "td");
            builder.AddContent(27, 
#line 32 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
                             forecast.Summary

#line default
#line hidden
            );
            builder.CloseElement();
            builder.AddMarkupContent(28, "\r\n                    ");
            builder.CloseElement();
            builder.AddMarkupContent(29, "\r\n");
#line 34 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
                }

#line default
#line hidden
            builder.AddContent(30, "            ");
            builder.CloseElement();
            builder.AddMarkupContent(31, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(32, "\r\n");
#line 37 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
    }

#line default
#line hidden
            builder.AddMarkupContent(33, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 42 "D:\Workspace\webAPI\src\App\Article.WebApp\Pages\FetchData.razor"
            
    WeatherForecast[] forecasts;
    protected override async Task OnInitAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
