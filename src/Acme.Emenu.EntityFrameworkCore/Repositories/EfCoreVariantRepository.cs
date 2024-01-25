using Acme.Emenu.Entities;
using Acme.Emenu.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.Emenu.Repositories
{
    internal class EfCoreVariantRepository : EfCoreRepository<EmenuDbContext, Variant, int>,
            IVariantRepository
    {
        public EfCoreVariantRepository(
      IDbContextProvider<EmenuDbContext> dbContextProvider)
      : base(dbContextProvider)
        {
            
        }
    }
}
