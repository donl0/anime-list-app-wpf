using AnimeDesktop.Model.Commands;
using AnimeDesktop.Model.Navigation;
using AnimeDesktop.Servises;
using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Model.Navigation.Commands
{
    public class NavigateCommand<TViewModel> : BaseCommand where TViewModel : BaseAnimeListViewModel
    {
        private readonly NavigationService<TViewModel> _navigationService;

        public NavigateCommand(INavigationStore navigationStore, NavigationService<TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
    }
}
