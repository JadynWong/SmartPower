using SmartPower.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SmartPower
{
    [DependsOn(
        typeof(SmartPowerEntityFrameworkCoreTestModule)
        )]
    public class SmartPowerDomainTestModule : AbpModule
    {

    }
}