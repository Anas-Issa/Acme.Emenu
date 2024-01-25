using Volo.Abp.Modularity;

namespace Acme.Emenu;

[DependsOn(
    typeof(EmenuDomainModule),
    typeof(EmenuTestBaseModule)
)]
public class EmenuDomainTestModule : AbpModule
{

}
