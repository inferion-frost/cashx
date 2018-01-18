using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Infrastructure.Models.Entities;

namespace Infrastructure.Repositories
{
    class PersonRepository : IPersonRepository
    {
        private readonly string _connnectionString;
        private ApplicationDbContext DbContext
        {
            get { return new ApplicationDbContext(_connnectionString); }
        }

        public PersonRepository(string connectionString)
        {
            _connnectionString = connectionString;
        }

        public Person CreatePerson(Person person)
        {
            using (var context = DbContext)
            {
                context.People.Add(person);
                context.SaveChanges();
                return person;
            }
        }

        public void DeletePerson(long personId)
        {
            using (var context = DbContext)
            {
                var targetPerson = context.People.Find(personId);
                context.People.Remove(targetPerson);
                context.SaveChanges();
            }
        }

        public ICollection<Person> GetPeople()
        {
            using (var context = DbContext)
            {
                return context.People.ToList();
            }
        }

        public Person GetPerson(long personId)
        {
            using (var context = DbContext)
            {
                return context.People.Find(personId);
            }
        }

        public Person UpdatePerson(Person person)
        {
            using (var context = DbContext)
            {
                context.Entry(person).State = person.Id == 0 ? EntityState.Added : EntityState.Modified;
                context.SaveChanges();
                return person;
            }
        }
    }
}
