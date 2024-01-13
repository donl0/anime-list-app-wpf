using AnimeDesktop.Model;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Model.Commands;

namespace AnimeDesktop.ViewModel
{
    public class TopHundredViewModel : BaseAnimeListViewModel
    {
        public TopHundredViewModel(ITakeDataQuery<List<Anime>> startQuerry, OpenAnimeWindowCommand openAnime, ShikiImageRuler imageRuler) : base(startQuerry, openAnime, imageRuler)
        {
        }
    }
}
