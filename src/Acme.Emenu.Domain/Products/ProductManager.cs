using Acme.Emenu.Entities;
using Acme.Emenu.Repsitpries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Volo.Abp.Uow;

namespace Acme.Emenu.Products
{
    public  class ProductManager:DomainService
    {
        private readonly IProductRepository _productRepository;
        //private readonly IProductTranslationRepository _productTranslationRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public ProductManager(IProductRepository productRepository,
            
             IUnitOfWorkManager unitOfWorkManager)
        {
            _productRepository = productRepository;
           
            _unitOfWorkManager = unitOfWorkManager;


        }

        public async Task<Product> CreateAsync(Product input)
        {
            // Validate input if needed

            var product = new Product
            {
                // Set other properties of the product
            };

            foreach (var translationDto in input.Translations)
            {
                var translation = new ProductTranslation
                {
                    Product = product,
                    Language = translationDto.Language,
                    Name = translationDto.Name,
                    Description = translationDto.Description
                };

                await _productRepository.InsertAsync(product);
            }

           // await _productRepository.InsertAsync(product);

            return product;
        }
    }
}
