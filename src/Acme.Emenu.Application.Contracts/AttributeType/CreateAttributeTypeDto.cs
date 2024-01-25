using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.Emenu.AttributeType
{
    public class CreateAttributeTypeDto
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; } = string.Empty;

        public List<string> Options { get; set; }
    }
}
