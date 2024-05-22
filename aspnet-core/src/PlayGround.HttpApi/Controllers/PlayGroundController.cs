using PlayGround.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PlayGround.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PlayGroundController : AbpControllerBase
{
    protected PlayGroundController()
    {
        LocalizationResource = typeof(PlayGroundResource);
    }
}
