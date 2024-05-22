using PlayGround.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PlayGround.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PlayGroundEntityFrameworkCoreModule),
    typeof(PlayGroundApplicationContractsModule)
)]
public class PlayGroundDbMigratorModule : AbpModule
{
}
