using AnimeDesktop.Base;
using AnimeDesktop.DB.Model;
using AnimeDesktop.Model.SymbolJob;

namespace AnimeDesktop.Model
{
    public class SymbolBookmarkHolder : NotifyPropertyChangeHandler, ISymbolBookmarkHolder
    {
        private char _abandonedSymbol;
        private char _watchedSymbol;
        private char _plannedSmbol;

        public SymbolBookmarkModel<AbandonedAnime> AbandonedModel { get; private set; }
        public SymbolBookmarkModel<WatchedAnime> WatchedModel { get; private set; }
        public SymbolBookmarkModel<PlannedAnime> PlannedModel { get; private set; }

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
            get { return _plannedSmbol; }
            private set
            {
                _plannedSmbol = value;
                OnPropertyChanged();
            }
        }

        public SymbolBookmarkHolder(SymbolBookmarkModel<AbandonedAnime> abandonedModel, SymbolBookmarkModel<WatchedAnime> watchedModel, SymbolBookmarkModel<PlannedAnime> plannedModel)
        {

            AbandonedModel = abandonedModel;
            WatchedModel = watchedModel;
            PlannedModel = plannedModel;

            Sub();
        }

        public async void UpdateAddInListSymbols(ShikimoriSharp.Classes.Anime anime)
        {
            await AbandonedModel.Update(anime.Id);
            await WatchedModel.Update(anime.Id);
            await PlannedModel.Update(anime.Id);
        }

        private void OnAbandonedUpdated(char symbol)
        {
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

        private void Sub()
        {
            AbandonedModel.SymbolUpdated += OnAbandonedUpdated;
            WatchedModel.SymbolUpdated += OnWatchedUpdated;
            PlannedModel.SymbolUpdated += OnPlannedUpdated;
        }
    }
}
