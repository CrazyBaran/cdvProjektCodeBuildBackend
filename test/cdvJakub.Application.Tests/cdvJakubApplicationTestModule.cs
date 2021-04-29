using Volo.Abp.Modularity;

namespace cdvJakub
{
    [DependsOn(
        typeof(cdvJakubApplicationModule),
        typeof(cdvJakubDomainTestModule)
        )]
    public class cdvJakubApplicationTestModule : AbpModule
    {

    }
}