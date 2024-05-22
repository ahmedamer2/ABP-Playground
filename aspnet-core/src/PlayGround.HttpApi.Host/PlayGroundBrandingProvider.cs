using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PlayGround;

[Dependency(ReplaceServices = true)]
public class PlayGroundBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PlayGround";
}
