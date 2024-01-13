using AnimeDesktop.Model;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Model.Commands;

namespace AnimeDesktop.ViewModel
{
    public class TopHundredViewModel : BaseAnimeListViewModel
    {
        public TopHundredViewModel(BaseTakeDataQuery<List<Anime>, ShikimoriClient> startModel, OpenAnimeWindowCommand openAnime, ShikiImageRuler imageRuler) : base(startModel, openAnime, imageRuler)
        {
        }
    }
}
