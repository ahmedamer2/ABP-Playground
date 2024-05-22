using Volo.Abp.Modularity;

namespace PlayGround;

[DependsOn(
    typeof(PlayGroundApplicationModule),
    typeof(PlayGroundDomainTestModule)
)]
public class PlayGroundApplicationTestModule : AbpModule
{

}
