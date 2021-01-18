using SmartPower.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SmartPower.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class SmartPowerPageModel : AbpPageModel
    {
        protected SmartPowerPageModel()
        {
            LocalizationResourceType = typeof(SmartPowerResource);
        }
    }
}