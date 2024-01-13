using AnimeDesktop.Model;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Model.Commands;
using AnimeDesktop.Model.Bookmarks;
using AnimeDesktop.Queries.Bookmarks;

namespace AnimeDesktop.ViewModel
{
    public class UserBookmarksViewModel : BaseAnimeListViewModel
    {
        ITakeDataQuery<List<Anime>> _watchedQuery;
        ITakeDataQuery<List<Anime>> _plannedQuery;
        ITakeDataQuery<List<Anime>> _abandonedQuery;

        public UserBookmarksViewModel(UserPlannedQuery plannedQuery, UserWatchedQuery watchedQuery, UserAbandonedQuerry abandonedQuerry, BaseTakeDataQuery<List<Anime>, ShikimoriClient> startQuerry, OpenAnimeWindowCommand openAnime, IShikiRuler<List<Anime>> imageRuler) : base(startQuerry, openAnime, imageRuler)
        {
            _watchedQuery = watchedQuery;
            _plannedQuery = plannedQuery;
            _abandonedQuery = abandonedQuerry;
        }

        public void SetWatched() { 
            UpdateWithQuerry(_watchedQuery);
        }
    }
}
