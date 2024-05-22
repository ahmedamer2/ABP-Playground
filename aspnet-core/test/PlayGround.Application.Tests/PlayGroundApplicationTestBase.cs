using Volo.Abp.Modularity;

namespace PlayGround;

public abstract class PlayGroundApplicationTestBase<TStartupModule> : PlayGroundTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
