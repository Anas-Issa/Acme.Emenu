using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Emenu.VariantAttributeOption
{
    public class UpdateVariantAttributeOptionDto :EntityDto<int>
    {
        public int VariantId { get; set; }

        public int AttributeOptionId { get; set; }
    }
}
