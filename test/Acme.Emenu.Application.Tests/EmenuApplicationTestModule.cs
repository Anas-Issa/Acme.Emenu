using Volo.Abp.Modularity;

namespace Acme.Emenu;

[DependsOn(
    typeof(EmenuApplicationModule),
    typeof(EmenuDomainTestModule)
)]
public class EmenuApplicationTestModule : AbpModule
{

}
