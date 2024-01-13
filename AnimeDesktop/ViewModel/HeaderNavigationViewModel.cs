using AnimeDesktop.Model.Commands;
using AnimeDesktop.Model.Navigation.Commands;

namespace AnimeDesktop.ViewModel
{
    public class HeaderNavigationViewModel
    {
        public NavigateCommand<TopHundredViewModel> NavigateTopAnimes { get; }
        public NavigateCommand<UserBookmarksViewModel> NavigateBookmarks { get; }
        public SearchAnimeCommand<SearchAnimesViewModel> NavigateSearch { get; }

        public HeaderNavigationViewModel(NavigateCommand<TopHundredViewModel> navigateTopAnimes, NavigateCommand<UserBookmarksViewModel> navigateBookmarks, SearchAnimeCommand<SearchAnimesViewModel> navigationSearch)
        {
            NavigateTopAnimes = navigateTopAnimes;
            NavigateBookmarks = navigateBookmarks;
            NavigateSearch = navigationSearch;
        }
    }
}
