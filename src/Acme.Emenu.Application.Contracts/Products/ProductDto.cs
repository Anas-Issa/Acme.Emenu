using Acme.Emenu.Variants;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AuditLogging;

namespace Acme.Emenu.Products
{
    public class ProductDto:EntityDto<int>
    {
        public List<ProductTranslationDto> Translations { get; set; }
        public List<ProductAttributeDto> Attributes { get; set; }

        public List<VariantDto> Variants{ get; set; }
    }
}
