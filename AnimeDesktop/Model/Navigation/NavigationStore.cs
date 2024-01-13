using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Model.Navigation
{
    class NavigationStore : INavigationStore
    {
        public BaseAnimeListViewModel CurrentViewModel { get; private set; }

        public event Action CurrentViewModelChanged;

        public NavigationStore(BaseAnimeListViewModel startView)
        {
            SetViewModel(startView);
        }

        public void SetViewModel(BaseAnimeListViewModel viewModel)
        {
            CurrentViewModel = viewModel;
            CurrentViewModelChanged?.Invoke();
        }
    }
}
