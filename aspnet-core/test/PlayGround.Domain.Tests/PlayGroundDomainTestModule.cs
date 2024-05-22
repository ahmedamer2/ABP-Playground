using Volo.Abp.Modularity;

namespace PlayGround;

[DependsOn(
    typeof(PlayGroundDomainModule),
    typeof(PlayGroundTestBaseModule)
)]
public class PlayGroundDomainTestModule : AbpModule
{

}
