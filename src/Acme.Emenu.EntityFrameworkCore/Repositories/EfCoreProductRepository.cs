using Acme.Emenu.Entities;
using Acme.Emenu.EntityFrameworkCore;
using Acme.Emenu.Repsitpries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.Emenu.Products
{
    internal class EfCoreProductRepository : EfCoreRepository<EmenuDbContext, Product, int>,
            IProductRepository
    {
        public EfCoreProductRepository(IDbContextProvider<EmenuDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override async Task<IQueryable<Product>> WithDetailsAsync()
        {
            var q = await base.WithDetailsAsync();

            return q.Include(x => x.Translations)
                .Include(x => x.Attributes)
                .ThenInclude(x => x.AttributeType)
                .Include(p=>p.Variants)
                .ThenInclude(x=>x.VariantAttributeOptions)
                .ThenInclude(x=>x.AttributeOption.AttributeType);
        }
    }
}
