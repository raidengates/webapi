using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Identities.WebAPI.DatabaseFactory
{
    public class IdentitiesWebAPIDbContextFactory : IDbContextFactory<IdentitiesWebAPIDbContext>
    {

        public IdentitiesWebAPIDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<IdentitiesWebAPIDbContext>();
            var variables = new EnviromentInformation();
            var connectionString =
             new ConnectionStringBuilder()
             .CreateConnectiongString(
                                      basePath: variables.GetBasePath(),
                                      environmentName: variables.GetEnviromentName()
                                     );
            builder.UseSqlServer(connectionString);

            return new IdentitiesWebAPIDbContext(builder.Options);
        }
    }
}
