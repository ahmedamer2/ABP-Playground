using Volo.Abp.Settings;

namespace PlayGround.Settings;

public class PlayGroundSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PlayGroundSettings.MySetting1));
    }
}
