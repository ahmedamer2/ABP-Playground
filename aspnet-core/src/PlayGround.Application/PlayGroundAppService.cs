using PlayGround.Localization;
using Volo.Abp.Application.Services;

namespace PlayGround;

/* Inherit your application services from this class.
 */
public abstract class PlayGroundAppService : ApplicationService
{
    protected PlayGroundAppService()
    {
        LocalizationResource = typeof(PlayGroundResource);
    }
}
