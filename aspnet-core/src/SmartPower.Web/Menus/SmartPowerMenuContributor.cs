using System.Threading.Tasks;
using SmartPower.Localization;
using SmartPower.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace SmartPower.Web.Menus
{
    public class SmartPowerMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<SmartPowerResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(SmartPowerMenus.Home, l["Menu:Home"], "~/"));
            context.Menu.Items.Insert(1, new ApplicationMenuItem(SmartPowerMenus.Blogging, l["Menu:Blogging"], "~/S"));
        }
    }
}
