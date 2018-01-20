using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Infrastructure.Models.Entities;

namespace Infrastructure.Services
{
    class AccountService : IAccountService
    {
        private readonly Connection _connection;

        public AccountService(Connection connection)
        {
            _connection = connection;
        }

        public Account CreateAccount(Account account)
        {
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
                return context.Accounts.FirstOrDefault(
                    account => account.Id == accountId) ??  throw new ArgumentException();
            }
        }

        public ICollection<Account> GetAccounts(long personId)
        {
            using (var context = _connection.GetContext())
            {
                return context.Accounts.ToList();
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
