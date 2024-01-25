using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.Emenu.AttributeType
{
    public interface IAttributeTypeAppService:IApplicationService
    {
        Task<AttributeTypeDto> GetAsync(int id);

        //Task<PagedResultDto<AttributeTypeDto>> GetListAsync(GetAttributeTypeListDto input);

        Task<AttributeTypeDto> CreateAsync(CreateAttributeTypeDto input);

        //Task UpdateAsync(int id, UpdateAttributeTypeDto input);

        Task DeleteAsync(int id);

    }
}
