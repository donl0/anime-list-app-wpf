using AnimeDesktop.Model;
using AnimeDesktop.Shiki;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.ViewModel
{
    class BaseAnimeListViewModel
    {
        private readonly IShikiImageRuler _imageRuler;

        public NotifyTaskCompletion<List<Anime>> Values { get; private set; }


        public BaseAnimeListViewModel(IAnimeListModel startModel) {
            _imageRuler = new ShikiImageRuler();

            Action<List<Anime>> onTaskCompleted = (animes) => _imageRuler.Rule(animes);

            Values = new NotifyTaskCompletion<List<Anime>>(Task.Run(() => startModel.TakeAnimes()), onTaskCompleted);
        }
    }
}
