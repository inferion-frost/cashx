using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Infrastructure.Models.Entities;

namespace Infrastructure.Services
{
    class AccountService : IAccountService
    {
        private readonly DbContextFactory _connection;

        public AccountService(DbContextFactory connection)
        {
            _connection = connection;
        }

        public Account CreateAccount(long personId)
        {
            Account account = new Account() { OwnerId = personId, Balance = 0m };
            using (var context = _connection.GetContext())
            {
                context.Accounts.Add(account);
                context.SaveChanges();
            }
            return account;
        }

        public void DeleteAccount(long accountId)
        {
            using (var context = _connection.GetContext())
            {
                context.Accounts.Remove(GetAccount(accountId));
                context.SaveChanges();
            }
        }

        public Account GetAccount(long accountId)
        {
            using (var context = _connection.GetContext())
            {
                return context.Accounts.Find(accountId);
            }
        }

        public ICollection<Account> GetAccounts(long personId)
        {
            using (var context = _connection.GetContext())
            {
                return context.Accounts.Where(account => account.OwnerId == personId).ToList();
            }
        }

        public Account UpdateAccount(Account account)
        {
            using (var context = _connection.GetContext())
            {
                context.Entry(account).State = EntityState.Modified;
                context.SaveChanges();
            }
            return account;
        }
    }
}
