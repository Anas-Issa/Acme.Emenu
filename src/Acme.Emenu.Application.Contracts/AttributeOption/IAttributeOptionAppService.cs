using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.Emenu.AttributeOption
{
    public interface IAttributeOptionAppService : IApplicationService
    {
        Task<AttributeOptionDto> CreateAsync(CreateAttributeOptionDto input);

    }
}
