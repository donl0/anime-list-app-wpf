using AnimeDesktop.Model;
using AnimeDesktop.Shiki;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Model.Commands;

namespace AnimeDesktop.ViewModel
{
    public class UserBookmarksViewModel : BaseAnimeListViewModel
    {
        public UserBookmarksViewModel(BaseTakeDataQuery<List<Anime>, ShikimoriClient> startModel, OpenAnimeWindowCommand openAnime, IShikiRuler<List<Anime>> imageRuler) : base(startModel, openAnime, imageRuler)
        {
        }
    }
}
