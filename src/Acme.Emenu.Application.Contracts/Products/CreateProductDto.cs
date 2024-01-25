using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Emenu.Products
{
    public class CreateProductDto
    {
        public List<CreateProductTranslationDto> Translations { get; set; }
        public List<int> Attributes { get; set; }
    }
}
