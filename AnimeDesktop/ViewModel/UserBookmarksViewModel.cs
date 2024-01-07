using AnimeDesktop.Model;
using AnimeDesktop.Shiki;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Commands;
using AnimeDesktop.Servises.DSRuler;

namespace AnimeDesktop.ViewModel
{
    public class UserBookmarksViewModel : BaseAnimeListViewModel
    {
        public UserBookmarksViewModel(BaseModel<List<Anime>, ClientShiki, ShikimoriClient> startModel, OpenAnimeWindowCommand openAnime, IShikiRuler<List<Anime>> imageRuler) : base(startModel, openAnime, imageRuler)
        {
        }
    }
}
