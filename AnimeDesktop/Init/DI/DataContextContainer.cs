using AnimeDesktop.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeDesktop.Init.DI
{
    public class DataContextContainer: IDataContextContainer
    {
        private static IServiceProvider _serviceProvider;

        public static TopHundredViewModel TopHundredDataContext => _serviceProvider.GetRequiredService<TopHundredViewModel>();
        public static UserBookmarksViewModel UserBookmarksDataContext => _serviceProvider.GetRequiredService<UserBookmarksViewModel>();
        public static MainWindowViewModel MainWindowDataContext => _serviceProvider.GetRequiredService<MainWindowViewModel>();
        public static SearchAnimesViewModel SearchAnimesDataContext => _serviceProvider.GetRequiredService<SearchAnimesViewModel>();
        public static HeaderNavigationViewModel HeaderNavigationDataContext => _serviceProvider.GetRequiredService<HeaderNavigationViewModel>();

        public void SetProvider(IServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
        }
    }
}
