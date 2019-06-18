using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Article.WebApp.Data;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.Material;
using Blazorise.Material;
using Microsoft.Extensions.Configuration;
using Article.WebApp.Domain;
namespace Article.WebApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddJsonFile("configuration.json")
               .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddSingleton<LoginService>();
            IConfigurationSection appGateway = Configuration.GetSection("Gateway");

            services.Configure<Gateway>(appGateway);
            
            services.AddBlazorise(options => {
                options.ChangeTextOnKeyPress = true;
            }).AddMaterialProviders().AddMaterialIcons();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMaterialProviders().UseMaterialIcons();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();

            app.UseStaticFiles();
           

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
            //app.UseMvc();
        }
    }
}
