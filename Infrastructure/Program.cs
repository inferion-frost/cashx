using Infrastructure.Models.Entities;
using System;

namespace Infrastructure
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source=MyData.sdf;Persist Security Info=False;";
            ApplicationDbContext context = new ApplicationDbContext(connectionString);
            context.Database.CreateIfNotExists();
            context.People.Add(new Person()
            {
                FullName="Beksultan Galiev",
                Email="inferion.frost@gmail.com",
                Phone="+996 0700 670 146",
                BirthDate=DateTime.Now
            });
            context.SaveChanges();
        }
    }
}
