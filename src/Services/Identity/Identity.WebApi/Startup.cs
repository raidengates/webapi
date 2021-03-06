﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.WebApi.Helpers;
using Identity.WebApi.Middlewares;
using Identity.WebApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;



using Microsoft.AspNetCore.Http;
using Users.Framework.Extensions;
using Users.Framework.Validation;
using Unititi.Framework.Extensions;
using Unititi.Framework.Helpers;
//Identity
namespace Identity.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddUsersFramework(Configuration);
            services.AddUnititiFramework(Configuration);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddScoped<ExceptionHandlerMiddleware>();
            IConfigurationSection appSettingSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingSection);
            services.AddScoped<HashEncrypt>();
            services.AddScoped<Identity.WebApi.Services.IIdentityService, Identity.WebApi.Services.IdentityService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory log)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            log.AddApplicationInsights(app.ApplicationServices, LogLevel.Information);
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
