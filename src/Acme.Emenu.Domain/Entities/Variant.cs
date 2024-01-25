using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.Emenu.Entities
{
    public class Variant:Entity<int>
    {
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public decimal Price { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public ICollection<VariantAttributeOption> VariantAttributeOptions { get; set; }



    }
}
