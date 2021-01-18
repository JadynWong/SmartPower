using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SmartPower.EntityFrameworkCore
{
    [DependsOn(
        typeof(SmartPowerEntityFrameworkCoreModule)
        )]
    public class SmartPowerEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SmartPowerMigrationsDbContext>();
        }
    }
}
