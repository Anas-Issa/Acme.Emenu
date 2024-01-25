using Volo.Abp.Settings;

namespace Acme.Emenu.Settings;

public class EmenuSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EmenuSettings.MySetting1));
    }
}
