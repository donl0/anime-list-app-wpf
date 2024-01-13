using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Model.Navigation
{
    public interface INavigationStore
    {
        public BaseAnimeListViewModel CurrentViewModel { get; }
        public event Action CurrentViewModelChanged;

        public void SetViewModel(BaseAnimeListViewModel viewModel);
    }
}
