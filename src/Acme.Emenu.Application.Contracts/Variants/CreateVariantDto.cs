using Acme.Emenu.AttributeOption;
using Acme.Emenu.Products;
using Acme.Emenu.VariantAttributeOption;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Emenu.Variants
{
    public  class CreateVariantDto
    {
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public decimal Price { get; set; }

        public List<int> Options { get; set; }
    }
}
