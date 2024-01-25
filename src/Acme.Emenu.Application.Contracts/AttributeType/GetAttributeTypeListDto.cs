using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Emenu.AttributeType
{
    public class GetAttributeTypeListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
