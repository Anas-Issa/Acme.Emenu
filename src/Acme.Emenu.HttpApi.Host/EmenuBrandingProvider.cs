using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Emenu;

[Dependency(ReplaceServices = true)]
public class EmenuBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Emenu";
}
