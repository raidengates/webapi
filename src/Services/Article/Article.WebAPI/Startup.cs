using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.Framework.Extensions;
using Article.WebApi.Helpers;
using Article.WebApi.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Unititi.Framework.Extensions;
using Users.Framework.Extensions;
//Article
namespace Article.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddArticleFramework(Configuration);
            services.AddUsersFramework(Configuration);
            services.AddUnititiFramework(Configuration);
            services.AddScoped<ExceptionHandlerMiddleware>();
            IConfigurationSection appSettingSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingSection);
            //Service xữ lý nghiệp vụ 




            //Service xữ lý nghiệp vụ 
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseMvc();
        }
    }
}
