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
    public class EfCoreAttributeOptionRepository : EfCoreRepository<EmenuDbContext, AttributeOption, int>,
            IAttributeOptionRepository
    {
        public EfCoreAttributeOptionRepository(IDbContextProvider<EmenuDbContext> dbContextProvider) : base(dbContextProvider)
        {
            
        }
    }
}
