using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SmartPower.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class SmartPowerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SmartPower";
    }
}
