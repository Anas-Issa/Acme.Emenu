using Acme.Emenu.AttributeOption;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AuditLogging;

namespace Acme.Emenu.AttributeType
{
    public class AttributeTypeDto:EntityDto<int>
    {
        public string Name {get; set; }
        public List<AttributeOptionDto> Options { get; set; }
    }
}
