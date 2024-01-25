using Acme.Emenu.Entities;
using Acme.Emenu.Repositories;
using Acme.Emenu.Repsitpries;
using Acme.Emenu.Variants;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.Emenu.Products
{
    public class ProductAppService : EmenuAppService, IProductAppService
    {
        private readonly IProductRepository _productRepository;
        private readonly IVariantRepository _variantRepository;
        
       // private readonly ProductManager _productManager;

        public ProductAppService(IProductRepository productRepository,IVariantRepository variantRepository)
        {
            //_productManager = productManager;
            _productRepository = productRepository;
            _variantRepository = variantRepository;
        }

        public async Task<ProductDto> CreateAsync(CreateProductDto input)
        {
            var product  = new Product()
            {
                Translations= new List<ProductTranslation>(),
                Attributes = new List<Acme.Emenu.Entities.ProductAttribute>()
            };

            input.Translations.ForEach(t => product.Translations.Add(new ProductTranslation
            {
                Language = t.Language,
                Name = t.Name,
                Description = t.Description
            }));

            input.Attributes.ForEach(a => product.Attributes.Add(new Entities.ProductAttribute
            {
                AttributeTypeId = a
            }));

            await _productRepository.InsertAsync(product);

            await UnitOfWorkManager.Current.CompleteAsync();

            return ObjectMapper.Map<Product, ProductDto>(product);
        }

        public async Task<ProductDto> GetAsync(int id)
        {
            var entity = await _productRepository.GetAsync(id, true);
            
            var dto = ObjectMapper.Map<Product, ProductDto>(entity);

            return dto;
        }

        public async Task<ProductDto> AddVariant(CreateVariantDto input)
        {
            var product = new Product();
            var dto= ObjectMapper.Map<Product, ProductDto>(product);
            var variant = new Variant()
            {
                Barcode = input.Barcode,
                Price = input.Price,
                ProductId = input.ProductId,
                VariantAttributeOptions=new List<Acme.Emenu.Entities.VariantAttributeOption>(),
            };
            foreach(var id in input.Options) 
            { 
                variant.VariantAttributeOptions.Add(new Entities.VariantAttributeOption { AttributeOptionId = id });
            }; 
            _variantRepository.InsertAsync(variant);
            return dto;
        }
    }
}
