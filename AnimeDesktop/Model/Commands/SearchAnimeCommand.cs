using AnimeDesktop.Model;
using AnimeDesktop.Servises;
using AnimeDesktop.ViewModel;

namespace AnimeDesktop.Model.Commands
{
    public class SearchAnimeCommand<TVM> : BaseCommand where TVM : BaseAnimeListViewModel
    {
        private readonly NavigationService<TVM> _navigationService;
        private readonly ISearchModel _searchModel;

        public SearchAnimeCommand(ISearchModel searchModel, NavigationService<TVM> navigationService)
        {

            _searchModel = searchModel;
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            string value = (string)parameter;

            _navigationService.Navigate();

            _searchModel.SetSearchText(value);
        }
    }
}
