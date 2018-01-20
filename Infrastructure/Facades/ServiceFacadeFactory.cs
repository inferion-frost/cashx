using Infrastructure.Services;

namespace Infrastructure.Facades
{
    public class ServiceFacadeFactory : IServiceFacadeFactory
    {
        private string ConnectionString { get; }

        public ServiceFacadeFactory(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IPersonServiceFacade GetPersonServiceFacade()
        {
            return new PersonServiceFacade(
                MapperConfigurator.MapperConfiguration(),
                new PersonService(new Connection(ConnectionString)));
        }
    }
}
