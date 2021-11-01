using BeniceSoft.GoldenToad.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BeniceSoft.GoldenToad.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class GoldenToadPageModel : AbpPageModel
    {
        protected GoldenToadPageModel()
        {
            LocalizationResourceType = typeof(GoldenToadResource);
        }
    }
}