using SmartPower.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SmartPower.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SmartPowerEntityFrameworkCoreDbMigrationsModule),
        typeof(SmartPowerApplicationContractsModule)
        )]
    public class SmartPowerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
