using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Emenu.AttributeOption
{
    public class UpdateAttributeOptionDto
    {
        [Required]
        [StringLength(256)]
        public string Value { get; set; }
        public int AttributeTypeId { get; set; }
    }
}
