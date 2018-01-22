using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Models.Entities;

namespace Infrastructure.Services
{
    internal class PersonService : IPersonService
    {
        private DbContextFactory _connection;
        private IAccountService _accountService;

        public PersonService(DbContextFactory connection,
            IAccountService accountService)
        {
            _connection = connection;
            _accountService = accountService;
        }

        public Person CreatePerson(Person person)
        {
            using (var context = _connection.GetContext())
            {
                context.People.Add(person);
                context.Accounts.Add(new Account { Owner = person, Balance = 0M });
                context.SaveChanges();
            }
            return person;
        }

        public void DeletePerson(long personId)
        {
            using (var context = _connection.GetContext())
            {
                var person = context.People.Find(personId);
                context.People.Remove(person);
                context.SaveChanges();
            }
        }

        public ICollection<Person> GetPeople()
        {
            using (var context = _connection.GetContext())
            {
                return context.People.ToList();
            }
        }

        public ICollection<Person> GetPeople(Func<Person, bool> filter)
        {
            using (var context = _connection.GetContext())
            {
                return context.People.Where(filter).ToList();
            }
        }

        public Person GetPerson(long personId)
        {
            using (var context = _connection.GetContext())
            {
                return context.People.Find(personId);
            }
        }

        public Person UpdatePerson(Person person)
        {
            using (var context = _connection.GetContext())
            {
                context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return person;
        }
    }
}
