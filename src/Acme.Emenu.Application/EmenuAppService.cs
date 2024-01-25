using System;
using System.Collections.Generic;
using System.Text;
using Acme.Emenu.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Emenu;

/* Inherit your application services from this class.
 */
public abstract class EmenuAppService : ApplicationService
{
    protected EmenuAppService()
    {
        LocalizationResource = typeof(EmenuResource);
    }
}
