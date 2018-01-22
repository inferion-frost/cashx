using Infrastructure.Facades;
using System.Configuration;

namespace WinFormApplication.Utils
{
    internal static class ServiceProvider
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["SqlServerCe"].ConnectionString;

        private static readonly IServiceFacadeFactory serviceFacadeFactory =
            new ServiceFacadeFactory(_connectionString);

        public static IPersonServiceFacade GetPersonService()
        {
            return serviceFacadeFactory.GetPersonServiceFacade();
        }

        public static ITransactionServiceFacade GetTransactionService()
        {
            return serviceFacadeFactory.GetTransactionServiceFacade();
        }

        public static IAccountServiceFacade GetAccountService()
        {
            return serviceFacadeFactory.GetAccountServiceFacade();
        }
    }
}
