using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Emenu.ProductAttribute
{
    public class CreateProductAttributeDto 
    {
        public int ProductId { get; set; }
        public int AttributeTypeId { get; set; }
    }
}
