using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.Emenu.Products
{
    public interface IProductAppService: IApplicationService
    {
        Task<ProductDto> CreateAsync(CreateProductDto input);
    }
}
