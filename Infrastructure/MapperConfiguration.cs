using AutoMapper;
using Infrastructure.Models.DTO;
using Infrastructure.Models.Entities;

namespace Infrastructure
{
    static class ApplicationMapper
    {
        public static IMapper GetMapper()
        {
            return new MapperConfiguration((config) =>
            {
                config.CreateMap<Person, GetPersonDTO>();
                config.CreateMap<UpdatePersonDTO, Person>();
                config.CreateMap<CreatePersonDTO, Person>();
                config.CreateMap<CreateTransactionDTO, Transaction>();
                config.CreateMap<GetPersonDTO, Person>();
                config.CreateMap<GetAccountDTO, Account>();
                config.CreateMap<GetTransactionDTO, Transaction>();
            }).CreateMapper();
        }
    }
}
