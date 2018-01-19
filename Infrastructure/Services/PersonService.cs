using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Models.Entities;

namespace Infrastructure.Services
{
    internal class PersonService : IPersonService
    {
        private Connection _connection;

        public PersonService(Connection connection)
        {
            _connection = connection;
        }

        public Person CreatePerson(Person person)
        {
            using (var context = _connection.GetContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    context.People.Add(person);
                    transaction.Commit();
                }
            }
            return person;
        }

        public void DeletePerson(long personId)
        {
            using (var context = _connection.GetContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    var person = GetPerson(personId);
                    context.People.Remove(person);
                }
            }
        }

        public ICollection<Person> GetPeople()
        {
            using (var context = _connection.GetContext())
            {
                return context.People.ToList();
            }
        }

        public ICollection<Person> GetPeople(Func<Person,bool> filter)
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
