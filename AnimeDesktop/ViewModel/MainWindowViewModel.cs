using AnimeDesktop.Base;
using AnimeDesktop.Model.Navigation;

namespace AnimeDesktop.ViewModel
{
    public class MainWindowViewModel : NotifyPropertyChangeHandler
    {
        private readonly INavigationStore _navigationStore;

        public BaseAnimeListViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainWindowViewModel(INavigationStore navigation) {
            _navigationStore = navigation;

            _navigationStore.CurrentViewModelChanged += OnNavigationChanged;
        }

        private void OnNavigationChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
