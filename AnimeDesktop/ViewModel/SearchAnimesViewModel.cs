using AnimeDesktop.Model;
using AnimeDesktop.Model.Commands;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Shiki;
using ShikimoriSharp;
using ShikimoriSharp.Classes;
using System.Windows.Input;

namespace AnimeDesktop.ViewModel
{
    public class SearchAnimesViewModel: BaseAnimeListViewModel, ISearchModel
    {
        private readonly AnimeWithNameQuery _model;

        private string _searchText;

        private event Action SearchTextUpdated;

        public ICommand TestCommand { get; }

        public SearchAnimesViewModel(UserWatchedQuery startModel, OpenAnimeWindowCommand openAnime, ShikiImageRuler imageRuler, AnimeWithNameQuery model) : base(startModel, openAnime, imageRuler)
        {
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

        protected override void UpdateWithModel<String>(BaseTakeDataClientPayloaded<List<Anime>, ShikimoriClient, String> model, String payload)
        {
            base.UpdateWithModel(model, payload);
        }
    }
}
