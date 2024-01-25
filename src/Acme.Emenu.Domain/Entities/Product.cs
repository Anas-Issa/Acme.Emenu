using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Emenu.Entities
{
    public class Product: Entity<int>

    {
        public ICollection<ProductTranslation> Translations { get; set; }
        public ICollection<ProductAttribute> Attributes{ get; set; }

        public ICollection<Variant> Variants { get; set; }  

        //public ICollection<AttributeType> Attributes { get; set; }

    }
}
