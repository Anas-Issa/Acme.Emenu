using Volo.Abp.Modularity;

namespace Acme.Emenu;

public abstract class EmenuApplicationTestBase<TStartupModule> : EmenuTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
