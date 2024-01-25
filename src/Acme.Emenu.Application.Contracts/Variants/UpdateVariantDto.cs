using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Emenu.Variants
{
    public class UpdateVariantDto:EntityDto<int>
    {
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public decimal Price { get; set; }
    }
}
