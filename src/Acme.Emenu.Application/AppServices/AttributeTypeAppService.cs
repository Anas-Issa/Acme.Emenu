using Acme.Emenu.AttributeType;
using Acme.Emenu.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Emenu.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Acme.Emenu.AttributeOption;
using System.Linq.Dynamic.Core;

namespace Acme.Emenu.AppServices
{
    public class AttributeTypeAppService :
    CrudAppService<
        Acme.Emenu.Entities.AttributeType, 
        AttributeTypeDto, 
        int, 
        PagedAndSortedResultRequestDto, 
        CreateAttributeTypeDto>, 
    IAttributeTypeAppService 
    {
        public AttributeTypeAppService(IRepository<Acme.Emenu.Entities.AttributeType, int> repository)
        : base(repository)
        {
        }

        public override Task<AttributeTypeDto> CreateAsync(CreateAttributeTypeDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task<AttributeTypeDto> UpdateAsync(int id, CreateAttributeTypeDto input)
        {
            return base.UpdateAsync(id, input);
        }

        protected override Task<IQueryable<Entities.AttributeType>> CreateFilteredQueryAsync(PagedAndSortedResultRequestDto input)
        {
            return Task.FromResult(Repository.WithDetails(x => x.Options).AsQueryable());
        }

        protected override Task<Entities.AttributeType> GetEntityByIdAsync(int id)
        {
            var e = Repository.WithDetails(x => x.Options)
                .FirstOrDefault(x => x.Id == id);

            return Task.FromResult(e);
        }
    }
}
