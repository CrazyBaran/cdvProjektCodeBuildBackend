using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace cdvJakub.EntityFrameworkCore
{
    [DependsOn(
        typeof(cdvJakubEntityFrameworkCoreModule)
        )]
    public class cdvJakubEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<cdvJakubMigrationsDbContext>();
        }
    }
}
