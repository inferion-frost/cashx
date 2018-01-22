using System;

namespace Infrastructure
{
    internal class DbContextFactory
    {
        private readonly string _connectionString;

        public DbContextFactory(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException();
        }

        public ApplicationDbContext GetContext()
        {
            return new ApplicationDbContext(_connectionString);
        }
    }
}
