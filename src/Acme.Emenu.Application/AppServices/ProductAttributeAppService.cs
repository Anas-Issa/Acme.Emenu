using Acme.Emenu.ProductAttribute;
using Acme.Emenu.Products;
using Acme.Emenu.Repositories;
using Acme.Emenu.Repsitpries;
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
    public class ProductAttributeAppService:
    CrudAppService<
        Acme.Emenu.Entities.ProductAttribute,
        ProductAttributeDto,
        int,
        PagedAndSortedResultRequestDto,
        CreateProductAttributeDto>, 
    IProductAttributeAppService 
    {
        private readonly IProductAttributeRepository _productAttributeRepository;

        public ProductAttributeAppService(IRepository<Acme.Emenu.Entities.ProductAttribute, int> repository)
       : base(repository)
        {

        }
    }
}
