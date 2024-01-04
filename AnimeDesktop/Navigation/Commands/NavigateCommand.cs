using AnimeDesktop.Commands;
using AnimeDesktop.Servises;
using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Navigation.Commands
{
    public class NavigateCommand<TViewModel> : BaseCommand where TViewModel: BaseAnimeListViewModel
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
