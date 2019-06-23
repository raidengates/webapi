using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Identity.Framework.DatabaseFactory
{
    public class IdentityFrameworkDbContextFactory : IDbContextFactory<IdentityFrameworkDbContext>
    {

        public IdentityFrameworkDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<IdentityFrameworkDbContext>();
            var variables = new EnviromentInformation();
            var connectionString =
             new ConnectionStringBuilder()
             .CreateConnectiongString(
                                      basePath: variables.GetBasePath(),
                                      environmentName: variables.GetEnviromentName()
                                     );
            builder.UseSqlServer(connectionString);

            return new IdentityFrameworkDbContext(builder.Options);
        }
    }
}
