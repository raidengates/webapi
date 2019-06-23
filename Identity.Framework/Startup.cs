using Identity.Framework.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Identity.Framework
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
          .AddEnvironmentVariables();
            Configuration = builder.Build();

        }
        public void ConfigureServices(IServiceCollection services)
        {

            var migrationsAssembly = typeof(Startup)
             .GetTypeInfo()
             .Assembly
             .GetName()
             .Name;
            services.AddEntityFrameWorkIdentityCustom();
            services.AddIdentityServer4Custom(Configuration.GetConnectionString("DefaultConnection"), migrationsAssembly);
        }
    }
}
