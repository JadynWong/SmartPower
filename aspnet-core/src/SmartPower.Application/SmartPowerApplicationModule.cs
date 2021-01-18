using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using EasyAbp.Abp.SettingUi;
using Volo.Blogging;
using Volo.Blogging.Admin;

namespace SmartPower
{
    [DependsOn(
        typeof(SmartPowerDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(SmartPowerApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule)
        )]
    [DependsOn(typeof(SettingUiApplicationModule))]
    [DependsOn(typeof(BloggingApplicationModule))]
    [DependsOn(typeof(BloggingAdminApplicationModule))]
    public class SmartPowerApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<SmartPowerApplicationModule>();
            });
        }
    }
}
