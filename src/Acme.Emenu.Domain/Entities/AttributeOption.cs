using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.Emenu.Entities
{
    public class AttributeOption:Entity<int>
    {
        public string Value { get; set; }

        public int AttributeTypeId { get; set; }
        [ForeignKey(nameof(AttributeTypeId))]
        public AttributeType AttributeType{ get; set; }
        //public Collection<AttributeOption> Attributes { get; set;}

    }
}
