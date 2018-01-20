using System;

namespace Infrastructure
{
    internal class Connection
    {
        private readonly string _connectionString;

        public Connection(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException();
        }

        public ApplicationDbContext GetContext()
        {
            return new ApplicationDbContext(_connectionString);
        }
    }
}
