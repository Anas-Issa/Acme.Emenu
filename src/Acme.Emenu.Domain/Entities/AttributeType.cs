using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.Emenu.Entities
{
    public  class AttributeType:Entity<int>
    {
        public string Name { get; set; }
        public ICollection<AttributeOption> Options { get; set;}
        
    }
}
