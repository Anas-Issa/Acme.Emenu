using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Emenu.AttributeOption
{
    public class AttributeOptionDto:EntityDto<int>
    {
        public string Value { get; set; }
        public int AttributeTypeId { get; set; }
    }
}
