using PlayGround.Samples;
using Xunit;

namespace PlayGround.EntityFrameworkCore.Applications;

[Collection(PlayGroundTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PlayGroundEntityFrameworkCoreTestModule>
{

}
