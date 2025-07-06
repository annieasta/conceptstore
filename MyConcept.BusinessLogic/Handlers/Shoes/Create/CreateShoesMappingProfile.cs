using AutoMapper;
using MyConcept.BusinessLogic.Handlers.Shoes.Create.Models;
using MyConcept.Data.Entities;

namespace MyConcept.BusinessLogic.Handlers.Shoes.Create
{
    public class CreateShoesMappingProfile : Profile
    {
        public CreateShoesMappingProfile()
        {
            CreateMap<CreateShoesDto, ShoeEntity>();
        }
    }
}
