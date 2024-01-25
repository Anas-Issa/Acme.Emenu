using Acme.Emenu.AttributeOption;
using Acme.Emenu.Entities;
using Acme.Emenu.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.Emenu.AppServices
{
    public class AttributeOptionAppService :
    CrudAppService<
        Acme.Emenu.Entities.AttributeOption, //The Book entity
        AttributeOptionDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateAttributeOptionDto>, //Used to create/update a book
    IAttributeOptionAppService //implement the IBookAppService
    {
        private readonly IAttributeOptionRepository _attributeOptionRepository;
        public AttributeOptionAppService(IRepository<Acme.Emenu.Entities.AttributeOption, int> repository)
     : base(repository)
        {

        }

        //public async Task<Acme.Emenu.Entities.AttributeOption> CreateAsync(CreateAttributeOptionDto input)
        //{
        //    var option = new Acme.Emenu.Entities.AttributeOption()
        //    {
        //        Value = input.Value,
        //        AttributeTypeId = input.AttributeTypeId,
        //    };
        //    await _attributeOptionRepository.InsertAsync(option);

        //    //await UnitOfWorkManager.Current.CompleteAsync();

        //    return ObjectMapper.Map<Acme.Emenu.Entities.AttributeOption, AttributeOptionDto>(option);
        //}
    }
}
