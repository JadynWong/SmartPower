using Volo.Abp.Bundling;

namespace SmartPower.Blazor
{
    public class SmartPowerBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css");
        }
    }
}
