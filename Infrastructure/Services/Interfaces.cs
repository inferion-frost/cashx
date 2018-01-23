using Infrastructure.Models.Entities;
using System;
using System.Collections.Generic;

namespace Infrastructure.Services
{
    internal interface IPersonService
    {
        Person CreatePerson(Person person);
        Person UpdatePerson(Person person);
        Person GetPerson(long personId);
        void DeletePerson(long personId);
        ICollection<Person> GetPeople();
        ICollection<Person> GetPeople(Func<Person,bool> filter);
    }

    internal interface IAccountService
    {
        Account UpdateAccount(Account account);
        Account GetAccount(long accountId);
        void DeleteAccount(long accountId);
        Account CreateAccount(long personId);
        ICollection<Account> GetAccounts(long personId);
    }

    internal interface ITransactionService
    {
        Transaction CreateTransaction(Transaction transaction); 
        Transaction GetTransaction(long transactionId);
        void DeleteTransaction(long transactionId);
        ICollection<Transaction> GetTransactions(long accountId);
    }

    internal interface ITransactionProcessorService
    {
        void Process(ref Transaction transaction);
        void Revert(ref Transaction transaction);
    }

}
