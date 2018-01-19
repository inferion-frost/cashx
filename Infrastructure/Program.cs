using AutoMapper;
using Infrastructure.Facades;
using Infrastructure.Models.DTO;
using Infrastructure.Models.Entities;
using Infrastructure.Repositories;
using Infrastructure.Services;
using System;

namespace Infrastructure
{
    internal static class Program
    {
        static MapperConfiguration mapperConfiguration()
        {
            return new MapperConfiguration((config) =>
            {
                config.CreateMap<Person, GetPersonDTO>();
                config.CreateMap<UpdatePersonDTO, Person>();
                config.CreateMap<CreatePersonDTO, Person>();
            });
        }

        static void Main(string[] args)
        {
            var mapper = mapperConfiguration().CreateMapper();
            var connectionString = "Data Source=MyData.sdf;Persist Security Info=False;";
            var personService = new PersonService(new Connection(connectionString));
            var personServiceFacade = new PersonServiceFacade(mapper, personService);
            foreach (var item in personServiceFacade.GetPeople())
            {
                Console.WriteLine(item);
            } 
            Console.ReadLine();
        }
    }
}
