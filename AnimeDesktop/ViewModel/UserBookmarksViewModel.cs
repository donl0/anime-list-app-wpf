using AnimeDesktop.Model;
using AnimeDesktop.Shiki;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Commands;

namespace AnimeDesktop.ViewModel
{
    class UserBookmarksViewModel : BaseAnimeListViewModel
    {
        public UserBookmarksViewModel(BaseModel<List<Anime>, ClientShiki, ShikimoriClient> startModel, OpenAnimeWindowCommand openAnime, IShikiImageRuler imageRuler) : base(startModel, openAnime, imageRuler)
        {
        }
    }
}
