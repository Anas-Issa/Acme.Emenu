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
using Acme.Emenu.Variants;

namespace Acme.Emenu.AppServices
{
    public class VariantAppService :
    CrudAppService<
        Acme.Emenu.Entities.Variant,
        VariantDto,
        int,
        PagedAndSortedResultRequestDto,
        CreateVariantDto>,
        IVariantAppService
    {
        private readonly IVariantRepository variantRepository;
        public VariantAppService(IRepository<Acme.Emenu.Entities.Variant, int> repository)
       : base(repository)
        {

        }
    }
}
