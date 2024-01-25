using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Emenu.Products
{
    public class CreateProductTranslationDto
    {
        public string Language { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
