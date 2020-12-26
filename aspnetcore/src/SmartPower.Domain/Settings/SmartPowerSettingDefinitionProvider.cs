using Volo.Abp.Settings;

namespace SmartPower.Settings
{
    public class SmartPowerSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SmartPowerSettings.MySetting1));
        }
    }
}
