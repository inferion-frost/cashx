using Infrastructure.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    internal interface IPersonService
    {
        Person CreatePerson(Person person);
        Person UpdatePerson(Person person);
        Person GetPerson(long personId);
        void DeletePerson(long personId);
        ICollection<Person> GetPeople();
        ICollection<Person> GetPeople(Func<Person,bool> filter);
    }
}
