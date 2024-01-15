using AnimeDesktop.Base;
using AnimeDesktop.DataStructure;
using AnimeDesktop.DB.Model;
using AnimeDesktop.Model.SymbolJob;
using AnimeDesktop.Servises.DrawableMarkerBuilder;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Servises.DSRuler.Description;

namespace AnimeDesktop.ViewModel
{
    public class CertainAnimeViewModel : NotifyPropertyChangeViewModel, ICertainAnimeViewModel
    {
        private readonly IShikiRuler<AnimeDrawable> _descriptionRuler;
        private readonly IDrawableMakerBuilder _builder;

        private char _abandonedSymbol;
        private char _watchedSymbol;
        private char _plannedSmbol;

        public SymbolBookmarkModel<AbandonedAnime> AbandonedModel { get; private set; }
        public SymbolBookmarkModel<WatchedAnime> WatchedModel { get; private set; }
        public SymbolBookmarkModel<PlannedAnime> PlannedModel { get; private set; }

        public NotifyTaskCompletion<AnimeDrawable> Value { get; private set; }

        public char AbandonedSymbol
        {
            get { return _abandonedSymbol; }
            private set
            {
                _abandonedSymbol = value;
                OnPropertyChanged();
            }
        }
        public char WatchedSymbol
        {
            get { return _watchedSymbol; }
            private set
            {
                _watchedSymbol = value;
                OnPropertyChanged();
            }
        }
        public char PlannedSmbol
        {
            get{ return _plannedSmbol; }
            private set
            {
                _plannedSmbol = value;
                OnPropertyChanged();
            }
        }

        public CertainAnimeViewModel(IDrawableMakerBuilder builder, ShikiDescriptionRulerDirector descriptionRuler, SymbolBookmarkModel<AbandonedAnime> abandonedModel, SymbolBookmarkModel<WatchedAnime> watchedModel, SymbolBookmarkModel<PlannedAnime> plannedModel)
        {
            _builder = builder;
            _descriptionRuler = descriptionRuler;

            AbandonedModel = abandonedModel;
            WatchedModel = watchedModel;
            PlannedModel = plannedModel;

            Sub();
        }

        public void Render(ShikimoriSharp.Classes.Anime anime)
        {
            AbandonedModel.Update(anime.Id);
            WatchedModel.Update(anime.Id);
            PlannedModel.Update(anime.Id);

            Action<AnimeDrawable> onTaskCompleted = (anime) => _descriptionRuler.Rule(anime);

            Value = new NotifyTaskCompletion<AnimeDrawable>(Task.Run(async () => await _builder.ToDrawable(anime)), onTaskCompleted);
        }

        private void OnAbandonedUpdated(char symbol) {
            AbandonedSymbol = symbol;
        }

        private void OnPlannedUpdated(char symbol)
        {
            PlannedSmbol = symbol;
        }

        private void OnWatchedUpdated(char symbol)
        {
            WatchedSymbol = symbol;
        }

        private void Sub() {
            AbandonedModel.SymbolUpdated += OnAbandonedUpdated;
            WatchedModel.SymbolUpdated += OnWatchedUpdated;
            PlannedModel.SymbolUpdated += OnPlannedUpdated;
        }
    }
}

