using BeniceSoft.GoldenToad.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BeniceSoft.GoldenToad.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class GoldenToadController : AbpController
    {
        protected GoldenToadController()
        {
            LocalizationResource = typeof(GoldenToadResource);
        }
    }
}