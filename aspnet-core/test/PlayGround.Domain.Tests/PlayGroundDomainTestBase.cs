using Volo.Abp.Modularity;

namespace PlayGround;

/* Inherit from this class for your domain layer tests. */
public abstract class PlayGroundDomainTestBase<TStartupModule> : PlayGroundTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
