using Infrastructure.Models.DTO;
using System.Collections.Generic;

namespace Infrastructure.Facades
{
    public interface IServiceFacadeFactory
    {
        IPersonServiceFacade GetPersonServiceFacade();
        ITransactionServiceFacade GetTransactionServiceFacade();
        IAccountServiceFacade GetAccountServiceFacade();
    }

    public interface IPersonServiceFacade
    {
        GetPersonDTO CreatePerson(CreatePersonDTO createPersonDTO);
        GetPersonDTO UpdatePerson(UpdatePersonDTO updatePersonDTO);
        GetPersonDTO GetPerson(long personId);
        void DeletePerson(long personId);
        ICollection<GetPersonDTO> GetPeople();
    }

    public interface IAccountServiceFacade
    {
        GetAccountDTO CreateAccount(long personId);
        GetAccountDTO GetAccount(long accountId);
        ICollection<GetAccountDTO> GetAccounts(long personId);
    }

    public interface ITransactionServiceFacade
    {
        ICollection<GetTransactionDTO> GetTransactions(long accountId);
        GetTransactionDTO CreateTransaction(CreateTransactionDTO transaction);
        void DeleteTransaction(long transactionId);
    }
}
