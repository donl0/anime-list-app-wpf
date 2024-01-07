using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Init.DI
{
    public interface IDataContextContainer
    {
        static HeaderNavigationViewModel HeaderNavigationDataContext { get; }
        static MainWindowViewModel MainWindowDataContext { get; }
        static SearchAnimesViewModel SearchAnimesDataContext { get; }
        static TopHundredViewModel TopHundredDataContext { get; }
        static UserBookmarksViewModel UserBookmarksDataContext { get; }

        public abstract void SetProvider(IServiceProvider serviceProvider);
    }
}