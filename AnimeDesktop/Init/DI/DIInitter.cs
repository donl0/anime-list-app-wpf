using Microsoft.Extensions.DependencyInjection;

namespace AnimeDesktop.Init.DI
{
    public class DIInitter : IInitter
    {
        private static IServiceProvider _provider;

        public static IDataContextContainer DataContextContainer { get; private set; }
        public static MainWindow MainWindow => _provider.GetRequiredService<MainWindow>();

        public async void Init()
        {
            InitServices();
        }

        private void InitServices()
        {
            IServiceCollection services = new ServiceCollection();

            IDIContainerInitter[] dIContainers = new IDIContainerInitter[]
            {
                new ServicesInitter(),
                new CommandsInitter(),
                new QueriesInitter(),
                new ViewMolelsInitter(),
                new ViewInitter(),
                new ClientInstanceInitter()
            };

            foreach (var container in dIContainers) {
                container.Init(services);
            }

            _provider = services.BuildServiceProvider();

            DataContextContainer = new DataContextContainer();
            DataContextContainer.SetProvider(_provider);
        }
    }
}
