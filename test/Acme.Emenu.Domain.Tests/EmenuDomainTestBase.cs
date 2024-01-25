using Volo.Abp.Modularity;

namespace Acme.Emenu;

/* Inherit from this class for your domain layer tests. */
public abstract class EmenuDomainTestBase<TStartupModule> : EmenuTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
