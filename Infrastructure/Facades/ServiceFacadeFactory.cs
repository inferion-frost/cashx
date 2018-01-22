using AutoMapper;
using Infrastructure.Services;

namespace Infrastructure.Facades
{
    public class ServiceFacadeFactory : IServiceFacadeFactory
    {
        private readonly DbContextFactory Connection;
        private readonly IMapper Mapper;

        public ServiceFacadeFactory(string connectionString)
        {
            Connection = new DbContextFactory(connectionString);
            Mapper = ApplicationMapper.GetMapper();
        }

        public IPersonServiceFacade GetPersonServiceFacade()
        {
            return new PersonServiceFacade(
                Mapper, new PersonService(Connection, new AccountService(Connection)));
        }

        public ITransactionServiceFacade GetTransactionServiceFacade()
        {
            return new TransactionServiceFacade(
                Mapper, new TransactionService(Connection));
        }

        public IAccountServiceFacade GetAccountServiceFacade()
        {
            return new AccountServiceFacade(
                Mapper, new AccountService(Connection));
        }
    }
}
