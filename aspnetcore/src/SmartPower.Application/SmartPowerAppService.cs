using System;
using System.Collections.Generic;
using System.Text;
using SmartPower.Localization;
using Volo.Abp.Application.Services;

namespace SmartPower
{
    /* Inherit your application services from this class.
     */
    public abstract class SmartPowerAppService : ApplicationService
    {
        protected SmartPowerAppService()
        {
            LocalizationResource = typeof(SmartPowerResource);
        }
    }
}
