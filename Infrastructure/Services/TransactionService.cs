using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Models.Constants;
using Infrastructure.Models.Entities;

namespace Infrastructure.Services
{
    internal class TransactionService : ITransactionService
    {
        private readonly DbContextFactory _connection;

        public TransactionService(DbContextFactory connection)
        {
            _connection = connection ?? throw new NullReferenceException();
        }

        public Transaction CreateTransaction(Transaction transaction)
        {
            using (var context = _connection.GetContext())
            {
                var accountToUpdate = context.Accounts.Find(transaction.AccountId);
                accountToUpdate.Balance += (transaction.TransactionType == TransactionType.Incoming)
                    ? transaction.Balance : -transaction.Balance;
                context.Transactions.Add(transaction);
                context.SaveChanges();
            }
            return transaction;
        }

        public void DeleteTransaction(long transactionId)
        {
            using (var context = _connection.GetContext())
            {
                var transactionToDelete = context.Transactions.Find(transactionId);
                context.Transactions.Remove(transactionToDelete);
                context.SaveChanges();
            }
        }

        public Transaction GetTransaction(long transactionId)
        {
            using (var context = _connection.GetContext())
            {
                return context.Transactions.Find(transactionId);
            }
        }

        public ICollection<Transaction> GetTransactions(long accountId)
        {
            using (var context = _connection.GetContext())
            {
                return context.Transactions
                    .Where(transaction => transaction.AccountId == accountId)
                    .ToList();
            }
        }
    }
}
