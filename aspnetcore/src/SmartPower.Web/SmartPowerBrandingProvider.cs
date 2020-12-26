using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SmartPower.Web
{
    [Dependency(ReplaceServices = true)]
    public class SmartPowerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SmartPower";
    }
}
