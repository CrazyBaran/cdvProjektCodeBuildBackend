using cdvJakub.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace cdvJakub.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class cdvJakubController : AbpController
    {
        protected cdvJakubController()
        {
            LocalizationResource = typeof(cdvJakubResource);
        }
    }
}