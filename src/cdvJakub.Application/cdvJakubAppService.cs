using System;
using System.Collections.Generic;
using System.Text;
using cdvJakub.Localization;
using Volo.Abp.Application.Services;

namespace cdvJakub
{
    /* Inherit your application services from this class.
     */
    public abstract class cdvJakubAppService : ApplicationService
    {
        protected cdvJakubAppService()
        {
            LocalizationResource = typeof(cdvJakubResource);
        }
    }
}
