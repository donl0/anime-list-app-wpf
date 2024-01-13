using AnimeDesktop.Base;
using AnimeDesktop.Model;
using AnimeDesktop.Servises.DSRuler;
using ShikimoriSharp;
using ShikimoriSharp.Classes;
using System.Windows.Input;

namespace AnimeDesktop.ViewModel
{
    public class BaseAnimeListViewModel:NotifyPropertyChangeViewModel
    {
        private readonly IShikiRuler<List<Anime>> _imageRuler;

        public NotifyTaskCompletion<List<Anime>> Values { get; private set; }
        public ICommand OpenAnime { get; }

        public BaseAnimeListViewModel(ITakeDataQuery<List<Anime>> startQuerry, ICommand openAnime, IShikiRuler<List<Anime>> imageRuler) {
            OpenAnime = openAnime;

            _imageRuler = imageRuler;

            UpdateWithQuerry(startQuerry);
        }

        protected void UpdateWithQuerry(ITakeDataQuery<List<Anime>> querry) {
            Update(querry.TakeData());
        }

        protected virtual void UpdateWithQuerry<TP>(ITakeDataQueryPayloaded<List<Anime>, TP> querry, TP payload)  {
            Update(querry.TakeData(payload));
        }

        private void Update(Task<List<Anime>> querryTakenData) {
            Action<List<Anime>> onTaskCompleted = (animes) => _imageRuler.Rule(animes);

            Values = new NotifyTaskCompletion<List<Anime>>(Task.Run(() => querryTakenData), onTaskCompleted);
        }
    }
}
