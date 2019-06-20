using Blazor.Client.Services.Contracts;
using Blazor.Client.Services.Implementations;
using Blazor.Client.States;
using Microsoft.AspNetCore.Blazor.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Blazorise;
using Blazorise.Material;
using Blazorise.Icons.Material;

namespace Blazor.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthorizationCore();
            services.AddScoped<AuthenticationStateProvider, IdentityAuthenticationStateProvider>();
            services.AddScoped<IdentityAuthenticationState>();
            services.AddScoped<IAuthorizeApi, AuthorizeApi>();
          
            services.AddBlazorise(options => {
                options.ChangeTextOnKeyPress = true;
            }).AddMaterialProviders().AddMaterialIcons();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.UseMaterialProviders().UseMaterialIcons();
            WebAssemblyHttpMessageHandler.DefaultCredentials = FetchCredentialsOption.Include;
            app.AddComponent<App>("app");
        }
    }
}
