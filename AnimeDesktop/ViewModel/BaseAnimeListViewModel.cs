using AnimeDesktop.Base;
using AnimeDesktop.Model;
using AnimeDesktop.Servises.DSRuler;
using ShikimoriSharp.Classes;
using System.Windows.Input;

namespace AnimeDesktop.ViewModel
{
    public class BaseAnimeListViewModel:NotifyPropertyChangeHandler
    {
        private readonly IShikiRuler<List<Anime>> _imageRuler;

        private List<Anime> _values;

        public List<Anime> Values
        {
            get { return _values; }
            set {
                _values = value;
                OnPropertyChanged();
                }
        }
        public ICommand OpenAnime { get; }

        public BaseAnimeListViewModel(ITakeDataQuery<List<Anime>> startQuerry, ICommand openAnime, IShikiRuler<List<Anime>> imageRuler) {
            OpenAnime = openAnime;

            _imageRuler = imageRuler;

            UpdateWithQuerry(startQuerry);
        }

        protected async void UpdateWithQuerry(ITakeDataQuery<List<Anime>> querry) {
            Update(querry.TakeData());
        }

        protected virtual void UpdateWithQuerry<TP>(ITakeDataQueryPayloaded<List<Anime>, TP> querry, TP payload)  {
            Update(querry.TakeData(payload));
        }

        private async void Update(Task<List<Anime>> querryTakenData) {

            List<Anime> animes = await Task.Run(() => querryTakenData);
            _imageRuler.Rule(animes);
            Values = animes;
        }
    }
}
    