using cdvJakub.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace cdvJakub.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(cdvJakubEntityFrameworkCoreDbMigrationsModule),
        typeof(cdvJakubApplicationContractsModule)
        )]
    public class cdvJakubDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
