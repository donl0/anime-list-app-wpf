using AnimeDesktop.Navigation;
using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Servises
{
    public class NavigationService<TViewModel> where TViewModel : BaseAnimeListViewModel
    {
        private readonly INavigationStore _navigationStore;
        private readonly TViewModel _viewModel;

        public NavigationService(INavigationStore navigationStore, TViewModel viewModel)
        {
            _navigationStore = navigationStore;
            _viewModel = viewModel;
        }

        public void Navigate() {
            _navigationStore.SetViewModel(_viewModel);
        }
    }
}
