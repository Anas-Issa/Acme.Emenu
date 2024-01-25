using Acme.Emenu.Samples;
using Xunit;

namespace Acme.Emenu.EntityFrameworkCore.Domains;

[Collection(EmenuTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<EmenuEntityFrameworkCoreTestModule>
{

}
