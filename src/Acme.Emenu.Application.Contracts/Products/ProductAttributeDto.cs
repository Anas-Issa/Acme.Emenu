using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Emenu.Products
{
    public class ProductAttributeDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
