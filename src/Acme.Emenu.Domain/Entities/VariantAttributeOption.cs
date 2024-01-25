using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.Emenu.Entities
{
    public class VariantAttributeOption:Entity<int>
    {
        public int VariantId { get; set; }

      public int   AttributeOptionId {  get; set; }

        [ForeignKey(nameof(AttributeOptionId))]
        public AttributeOption AttributeOption { get; set; }

        [ForeignKey(nameof(VariantId))]
        public Variant Variant {  get; set; }

       


    }
}
