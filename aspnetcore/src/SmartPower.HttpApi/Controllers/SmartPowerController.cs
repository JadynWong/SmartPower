using SmartPower.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SmartPower.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SmartPowerController : AbpController
    {
        protected SmartPowerController()
        {
            LocalizationResource = typeof(SmartPowerResource);
        }
    }
}