using Acme.Emenu.Products;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Emenu.Variants
{
    public class VariantDto :EntityDto<int>
    {
        //public int ProductId { get; set; }
        public string Barcode { get; set; }
        public decimal Price { get; set; }

       public List<VariantAttributeOptionDto> Options { get; set; }

    }
}
