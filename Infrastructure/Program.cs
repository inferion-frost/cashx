using Infrastructure.Facades;
using Infrastructure.Services;
using System;

namespace Infrastructure
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var mapper = MapperConfigurator.MapperConfiguration();
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
