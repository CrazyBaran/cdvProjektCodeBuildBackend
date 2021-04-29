using Volo.Abp.Settings;

namespace cdvJakub.Settings
{
    public class cdvJakubSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(cdvJakubSettings.MySetting1));
        }
    }
}
