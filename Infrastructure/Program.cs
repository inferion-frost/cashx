using Infrastructure.Facades;
using Infrastructure.Models.Entities;
using Infrastructure.Services;
using System;
using System.Threading.Tasks;

namespace Infrastructure
{
    internal static class Program
    {
        private static DbContextFactory connection = new DbContextFactory("Data Source=SampleX.sdf;Persist Security Info=False;");

        static void Outer()
        {
            using (var context = connection.GetContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    var person = context.People.Add(new Person()
                    {
                        Phone = "0557",
                        BirthDate = DateTime.Now,
                        Email = "sss@gmail.com",
                        FullName = "XXXX"
                    });
                    context.SaveChanges();
                    Task.Run(()=> Inner(person.Id));
                    transaction.Commit();
                }
            }
        }
        static void Inner(long personId)
        {
            using (var context = connection.GetContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    context.Accounts.Add(new Account()
                    {
                        Balance = 0M,
                        OwnerId = personId
                    });
                    context.SaveChanges();
                    transaction.Commit();
                }
            }
        }

        static void Main(string[] args)
        {
            Outer();
        }
    }
}
