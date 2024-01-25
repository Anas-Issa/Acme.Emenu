using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.Emenu.Entities
{
    public class ProductAttribute:Entity<int>
    {
        public int ProductId { get; set; }
        public int AttributeTypeId {  get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        [ForeignKey(nameof(AttributeTypeId))]
        public AttributeType AttributeType { get; set; }            


    }
}
