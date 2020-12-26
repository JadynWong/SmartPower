using Volo.Abp.Modularity;

namespace SmartPower
{
    [DependsOn(
        typeof(SmartPowerApplicationModule),
        typeof(SmartPowerDomainTestModule)
        )]
    public class SmartPowerApplicationTestModule : AbpModule
    {

    }
}