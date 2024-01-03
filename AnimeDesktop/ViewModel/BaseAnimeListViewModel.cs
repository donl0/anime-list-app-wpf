using AnimeDesktop.Model;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Shiki;
using ShikimoriSharp;
using ShikimoriSharp.Classes;
using System.Windows.Input;

namespace AnimeDesktop.ViewModel
{
    public class BaseAnimeListViewModel
    {
        private readonly IShikiImageRuler _imageRuler;

        public NotifyTaskCompletion<List<Anime>> Values { get; private set; }
        public ICommand OpenAnime { get; }

        public BaseAnimeListViewModel(BaseModel<List<Anime>, ClientShiki, ShikimoriClient> startModel, ICommand openAnime, IShikiImageRuler imageRuler) {
            OpenAnime = openAnime;

            _imageRuler = imageRuler;

            Action<List<Anime>> onTaskCompleted = (animes) => _imageRuler.Rule(animes);

            Values = new NotifyTaskCompletion<List<Anime>>(Task.Run(() => startModel.TakeData()), onTaskCompleted);
        }
    }
}
