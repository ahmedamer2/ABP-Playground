using PlayGround.Samples;
using Xunit;

namespace PlayGround.EntityFrameworkCore.Domains;

[Collection(PlayGroundTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PlayGroundEntityFrameworkCoreTestModule>
{

}
