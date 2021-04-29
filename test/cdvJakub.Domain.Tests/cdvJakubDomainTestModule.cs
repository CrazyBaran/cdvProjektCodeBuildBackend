using cdvJakub.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace cdvJakub
{
    [DependsOn(
        typeof(cdvJakubEntityFrameworkCoreTestModule)
        )]
    public class cdvJakubDomainTestModule : AbpModule
    {

    }
}