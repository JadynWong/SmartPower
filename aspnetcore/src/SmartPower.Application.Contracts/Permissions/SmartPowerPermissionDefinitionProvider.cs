using SmartPower.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SmartPower.Permissions
{
    public class SmartPowerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SmartPowerPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SmartPowerPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SmartPowerResource>(name);
        }
    }
}
