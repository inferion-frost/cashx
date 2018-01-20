using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models.Constants;
using Infrastructure.Models.Entities;

namespace Infrastructure.Services
{
    internal class TransactionService : ITransactionService
    {
        private readonly Connection _connection;

        public TransactionService(Connection connection)
        {
            _connection = connection;
        }

        public Transaction CreateTransaction(Transaction transaction)
        {
            using (var context = _connection.GetContext())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    transaction.Account.Balance += (transaction.TransactionType == TransactionType.Incoming)
                        ? transaction.Balance : -transaction.Balance;
                    context.Transactions.Add(transaction);
                    dbContextTransaction.Commit();
                }
            }
            return transaction;
        }

        public void DeleteTransaction(long transactionId)
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransaction(long transactionId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Transaction> GetTransactions(long accountId)
        {
            using (var context = _connection.GetContext())
            {
                return context.Transactions.Where(transaction => transaction.AccountId == accountId).ToList();
            }
        }

        public Transaction UpdateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
