using AutoMapper;
using PokemonWebAPI_ER.Dto;
using PokemonWebAPI_ER.Models;

namespace PokemonWebAPI_ER.Automapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //////////////////////////////////these are while reading the data
            ///CreateMap<TSource, TDestination>()
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Review, ReviewDto>();
            CreateMap<Reviewer, ReviewerDto>();
            ///////////////////////////////////these are while creating the data
            CreateMap<CategoryDto, Category>();
            CreateMap<CountryDto, Country>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<ReviewDto, Review>();
            CreateMap<ReviewerDto, Reviewer>();
            
        }
    }
}
