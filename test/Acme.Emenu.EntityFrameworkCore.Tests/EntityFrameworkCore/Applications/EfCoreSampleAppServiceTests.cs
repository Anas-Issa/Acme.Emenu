using Acme.Emenu.Samples;
using Xunit;

namespace Acme.Emenu.EntityFrameworkCore.Applications;

[Collection(EmenuTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EmenuEntityFrameworkCoreTestModule>
{

}
