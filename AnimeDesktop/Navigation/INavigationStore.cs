using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Navigation
{
    public interface INavigationStore
    {
        public BaseAnimeListViewModel CurrentViewModel { get; }
        public event Action CurrentViewModelChanged;

        public void SetViewModel(BaseAnimeListViewModel viewModel);
    }
}
