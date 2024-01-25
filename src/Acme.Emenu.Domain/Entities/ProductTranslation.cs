using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.Emenu.Entities
{
    public class ProductTranslation:Entity<int>
    {
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Language { get; set; }
    }
}
