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

        public NotifyTaskCompletion<List<Anime>> Values { get; protected set; }
        public ICommand OpenAnime { get; }

        public BaseAnimeListViewModel(BaseTakeDataQuery<List<Anime>, ShikimoriClient> startModel, ICommand openAnime, IShikiRuler<List<Anime>> imageRuler) {
            OpenAnime = openAnime;

            _imageRuler = imageRuler;

            UpdateWithModel(startModel);
        }

        protected void UpdateWithModel(BaseTakeDataQuery<List<Anime>, ShikimoriClient> model) {
            Update(model.TakeData());
        }

        protected virtual void UpdateWithModel<TP>(BaseTakeDataClientPayloaded<List<Anime>, ShikimoriClient, TP> model, TP payload)  {
            Update(model.TakeData(payload));
        }

        private void Update(Task<List<Anime>> modelTakenData) {
            Action<List<Anime>> onTaskCompleted = (animes) => _imageRuler.Rule(animes);

            Values = new NotifyTaskCompletion<List<Anime>>(Task.Run(() => modelTakenData), onTaskCompleted);
        }
    }
}
