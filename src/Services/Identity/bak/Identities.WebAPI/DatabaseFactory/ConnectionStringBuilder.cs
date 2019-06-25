using Microsoft.Extensions.Configuration;

namespace Identities.WebAPI.DatabaseFactory
{
    public class ConnectionStringBuilder
    {
        public virtual string CreateConnectiongString(string basePath, string environmentName)
        {
            var databaseConnectionString = new ConfigurationBuilder()
               .SetBasePath(basePath)
               .AddJsonFile("appsettings.json")
               .AddJsonFile($"appsettings.{environmentName}.json", true)
               .AddEnvironmentVariables()
               .Build()
               .GetConnectionString("DefaultConnection");
            return databaseConnectionString;
        }
    }
}