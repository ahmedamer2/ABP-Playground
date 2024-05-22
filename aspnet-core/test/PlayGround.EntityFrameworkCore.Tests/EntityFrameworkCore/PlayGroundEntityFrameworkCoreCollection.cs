using Xunit;

namespace PlayGround.EntityFrameworkCore;

[CollectionDefinition(PlayGroundTestConsts.CollectionDefinitionName)]
public class PlayGroundEntityFrameworkCoreCollection : ICollectionFixture<PlayGroundEntityFrameworkCoreFixture>
{

}
