using System;
using System.Collections.Generic;
using Infrastructure.Models.Constants;
using Infrastructure.Models.Entities;

namespace Infrastructure.Services
{
    internal delegate void TransactionProcessor(ref Transaction transaction);

    internal class TransactionProcessorService : ITransactionProcessorService
    {
        private IDictionary<TransactionType, TransactionProcessor> _processors =
            new Dictionary<TransactionType, TransactionProcessor>()
            {
                { TransactionType.Incoming, ProcessIncomingTransaction },
                { TransactionType.Outcoming, ProcessOutcomingTransaction }
            };

        private IDictionary<TransactionType, TransactionProcessor> _ejectors =
            new Dictionary<TransactionType, TransactionProcessor>()
            {
                { TransactionType.Incoming, ProcessOutcomingTransaction },
                { TransactionType.Outcoming, ProcessIncomingTransaction }
            };



        public void Process(ref Transaction transaction)
        {
            try
            {
                _processors[transaction.TransactionType].Invoke(ref transaction);
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException($"No transaction processor found for `{transaction.TransactionType}` type");
            }
        }

        public void Revert(ref Transaction transaction)
        {
            try
            {
                _ejectors[transaction.TransactionType].Invoke(ref transaction);
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException($"No transaction ejector found for `{transaction.TransactionType}` type");
            }
        }

        private static void ProcessIncomingTransaction(ref Transaction transaction)
        {
            transaction.Account.Balance += transaction.Balance;
        }

        private static void ProcessOutcomingTransaction(ref Transaction transaction)
        {
            transaction.Account.Balance -= transaction.Balance;
        }

    }
}
