using Acme.Emenu.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Emenu.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EmenuController : AbpControllerBase
{
    protected EmenuController()
    {
        LocalizationResource = typeof(EmenuResource);
    }
}
