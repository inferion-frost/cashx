using System.Collections.Generic;
using System.Linq;
using Infrastructure.Models.Entities;

namespace Infrastructure.Services
{
    internal class TransactionService : ITransactionService
    {
        private readonly DbContextFactory _connection;
        private readonly ITransactionProcessorService _transactionProcessorService;

        public TransactionService(
            DbContextFactory connection,
            ITransactionProcessorService transactionProcessorService)
        {
            _connection = connection;
            _transactionProcessorService = transactionProcessorService;
        }

        public Transaction CreateTransaction(Transaction transaction)
        {
            using (var context = _connection.GetContext())
            {
                context.Transactions.Attach(transaction);
                context.Entry(transaction).Reference(tr => tr.Account).Load();
                _transactionProcessorService.Process(ref transaction);
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
                context.Entry(transactionToDelete).Reference(tr => tr.Account).Load();
                _transactionProcessorService.Revert(ref transactionToDelete);
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
