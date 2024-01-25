using Xunit;

namespace Acme.Emenu.EntityFrameworkCore;

[CollectionDefinition(EmenuTestConsts.CollectionDefinitionName)]
public class EmenuEntityFrameworkCoreCollection : ICollectionFixture<EmenuEntityFrameworkCoreFixture>
{

}
