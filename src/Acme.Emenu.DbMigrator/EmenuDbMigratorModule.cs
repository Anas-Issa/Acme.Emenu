using Acme.Emenu.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.Emenu.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EmenuEntityFrameworkCoreModule),
    typeof(EmenuApplicationContractsModule)
    )]
public class EmenuDbMigratorModule : AbpModule
{
}
