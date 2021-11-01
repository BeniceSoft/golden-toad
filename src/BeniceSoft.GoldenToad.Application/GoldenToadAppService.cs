using System;
using System.Collections.Generic;
using System.Text;
using BeniceSoft.GoldenToad.Localization;
using Volo.Abp.Application.Services;

namespace BeniceSoft.GoldenToad
{
    /* Inherit your application services from this class.
     */
    public abstract class GoldenToadAppService : ApplicationService
    {
        protected GoldenToadAppService()
        {
            LocalizationResource = typeof(GoldenToadResource);
        }
    }
}
