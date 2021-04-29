using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace cdvJakub.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class cdvJakubMigrationsDbContextFactory : IDesignTimeDbContextFactory<cdvJakubMigrationsDbContext>
    {
        public cdvJakubMigrationsDbContext CreateDbContext(string[] args)
        {
            cdvJakubEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<cdvJakubMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new cdvJakubMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../cdvJakub.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
