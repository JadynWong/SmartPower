using SmartPower.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SmartPower.Blazor
{
    public abstract class SmartPowerComponentBase : AbpComponentBase
    {
        protected SmartPowerComponentBase()
        {
            LocalizationResource = typeof(SmartPowerResource);
        }
    }
}
