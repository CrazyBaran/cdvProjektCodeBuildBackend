using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace cdvJakub
{
    [Dependency(ReplaceServices = true)]
    public class cdvJakubBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "cdvJakub";
    }
}
