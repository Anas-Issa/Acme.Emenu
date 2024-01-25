using Acme.Emenu.AttributeOption;
using Acme.Emenu.AttributeType;
using Acme.Emenu.Entities;
using Acme.Emenu.ProductAttribute;
using Acme.Emenu.Products;
using Acme.Emenu.VariantAttributeOption;
using Acme.Emenu.Variants;
using AutoMapper;
using System.Linq;

namespace Acme.Emenu;

public class EmenuApplicationAutoMapperProfile : Profile
{
    public EmenuApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Product, ProductDto>();
        CreateMap<ProductTranslation, ProductTranslationDto>();
        CreateMap<Acme.Emenu.Entities.ProductAttribute, ProductAttributeDto>()
            .ForMember(x => x.Id, o => o.MapFrom(x => x.AttributeTypeId))
            .ForMember(x => x.Name, o => o.MapFrom(x => x.AttributeType.Name));
        CreateMap<Acme.Emenu.Entities.AttributeType, AttributeTypeDto>();
        CreateMap<CreateAttributeTypeDto, Acme.Emenu.Entities.AttributeType>()
            .ForMember(x=>x.Options,o => o.MapFrom(x => x.Options.Select(t => new Acme.Emenu.Entities.AttributeOption
            {
                Value=t
            })))
            ;
        CreateMap<CreateAttributeOptionDto, Acme.Emenu.Entities.AttributeOption>();
        CreateMap<Acme.Emenu.Entities.AttributeOption, AttributeOptionDto>();
        CreateMap<CreateProductAttributeDto, Acme.Emenu.Entities.ProductAttribute>();
        
        CreateMap<CreateVariantDto, Acme.Emenu.Entities.Variant>();
        CreateMap<Acme.Emenu.Entities.Variant, VariantDto>()
            .ForMember(x=>x.Options,o=>o.MapFrom(x=>x.VariantAttributeOptions.Select(t=>new VariantAttributeOptionDto { 
                
                Name=t.AttributeOption.AttributeType.Name,
                Value=t.AttributeOption.Value
            
            })))
            ;

        CreateMap<CreateVariantAttributeOptionDto, Acme.Emenu.Entities.VariantAttributeOption>();
        CreateMap<Acme.Emenu.Entities.VariantAttributeOption, VariantAttributeOptionDto>();

    }
}
