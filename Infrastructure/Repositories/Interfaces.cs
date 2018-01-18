using Infrastructure.Models.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    interface IPersonRepository
    {
        Person CreatePerson(Person person);
        Person UpdatePerson(Person person);
        Person GetPerson(long personId);
        void DeletePerson(long personId);
        ICollection<Person> GetPeople();
    }
}
