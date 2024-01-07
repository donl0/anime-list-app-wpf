using AnimeDesktop.Commands;
using AnimeDesktop.Model;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Shiki;
using ShikimoriSharp;
using ShikimoriSharp.Classes;
using System.Windows.Input;

namespace AnimeDesktop.ViewModel
{
    public class SearchAnimesViewModel: BaseAnimeListViewModel, ISearchModel
    {
        private readonly AnimeWithNameModel _model;
        private readonly ShikiImageRuler _imageRuler;

        private string _searchText;

        private event Action SearchTextUpdated;

        public ICommand TestCommand { get; }

        public SearchAnimesViewModel(UserWatchedModel startModel, OpenAnimeWindowCommand openAnime, ShikiImageRuler imageRuler, AnimeWithNameModel model) : base(startModel, openAnime, imageRuler)
        {
            _imageRuler = imageRuler;
            _model = model;
            SearchTextUpdated += OnSearchTextUpdated;
        }

        public void SetSearchText(string value)
        {
            _searchText = value;
            SearchTextUpdated?.Invoke();
        }

        private void OnSearchTextUpdated()
        {
            UpdateWithModel(_model, _searchText);
        }

        protected override void UpdateWithModel<String>(BasePayloadedModel<List<Anime>, ClientShiki, ShikimoriClient, String> model, String payload)
        {
            base.UpdateWithModel(model, payload);
        }
    }
}
