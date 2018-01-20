using AutoMapper;
using Infrastructure.Models.DTO;
using Infrastructure.Models.Entities;

namespace Infrastructure
{
    static class MapperConfigurator
    {
        public static IMapper MapperConfiguration()
        {
            return new MapperConfiguration((config) =>
            {
                config.CreateMap<Person, GetPersonDTO>();
                config.CreateMap<UpdatePersonDTO, Person>();
                config.CreateMap<CreatePersonDTO, Person>();
            }).CreateMapper();
        }
    }
}
