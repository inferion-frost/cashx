using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models.Entities;
using Infrastructure.Repositories;

namespace Infrastructure.Services
{
    internal class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException();
        }

        public Person CreatePerson(Person person)
        {
            return _repository.CreatePerson(person);
        }

        public void DeletePerson(long personId)
        {
            _repository.DeletePerson(personId);
        }

        public ICollection<Person> GetPeople()
        {
            return _repository.GetPeople();
        }

        public ICollection<Person> GetPeople(Predicate<Person> filter)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(long personId)
        {
            return _repository.GetPerson(personId);
        }

        public Person UpdatePerson(Person person)
        {
            return _repository.UpdatePerson(person);
        }
    }
}
