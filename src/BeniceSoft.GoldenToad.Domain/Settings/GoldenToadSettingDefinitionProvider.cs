using Volo.Abp.Settings;

namespace BeniceSoft.GoldenToad.Settings
{
    public class GoldenToadSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(GoldenToadSettings.MySetting1));
        }
    }
}
