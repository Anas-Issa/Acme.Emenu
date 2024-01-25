using Acme.Emenu.Entities;
using Acme.Emenu.EntityFrameworkCore;
using Acme.Emenu.Repositories;
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
    public class EfCoreAttributeTypeRepository : EfCoreRepository<EmenuDbContext, AttributeType, int>,
            IAttributeTypeRepository
    {
        public EfCoreAttributeTypeRepository(
       IDbContextProvider<EmenuDbContext> dbContextProvider)
       : base(dbContextProvider)
        {
        }

        //public Task<AttributeType> CreateAsync(string name)
        //{
        //    throw new NotImplementedException();
        //

        public override IQueryable<AttributeType> WithDetails()
        {

            return base.WithDetails();
        }



    }
}
