using Acme.Emenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.Emenu.Repositories
{
    public interface IProductAttributeRepository : IRepository<ProductAttribute, int>
    {
    }
}
