using Volo.Abp.Identity;

namespace PlayGround;

public static class PlayGroundConsts
{
    public const string DbTablePrefix = "App";
    public const string? DbSchema = "Playground";
    public const string AdminEmailDefaultValue = IdentityDataSeedContributor.AdminEmailDefaultValue;
    public const string AdminPasswordDefaultValue = IdentityDataSeedContributor.AdminPasswordDefaultValue;
}
