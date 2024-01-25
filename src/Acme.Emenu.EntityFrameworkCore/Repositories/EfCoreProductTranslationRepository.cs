using Acme.Emenu.Entities;
using Acme.Emenu.EntityFrameworkCore;
using Acme.Emenu.Repsitpries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.Emenu.Products
{
    public class EfCorePRoductTranslationRepository : EfCoreRepository<EmenuDbContext, ProductTranslation, int>,IProductTranslationRepository
    {
        public EfCorePRoductTranslationRepository(IDbContextProvider<EmenuDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
