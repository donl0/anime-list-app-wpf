using AnimeDesktop.DataStructure;
using AnimeDesktop.DB.Model;
using AnimeDesktop.Model.Commands;

namespace AnimeDesktop.Model.SymbolJob
{
    public class SymbolBookmarkModel<T> : BaseCommand where T: class, IAnimeHolder, new()
    {
        public Action<char> SymbolUpdated;

        private const char _existSymbol = '+';
        private const char _nonExistSymbol = ' ';

        private readonly IDataBaseQueries _dataBaseQueries;

        public SymbolBookmarkModel(IDataBaseQueries dataBaseQueries)
        {
            _dataBaseQueries = dataBaseQueries;
        }

        public override void Execute(object? parameter)
        {
            AnimeDrawable item = parameter as AnimeDrawable;

            long id = item.Id;

            if (!_dataBaseQueries.CheckIfAnimeExist<T>(id))
            {
                if (_dataBaseQueries.TryAddAnime<T>(id))
                    SymbolUpdated?.Invoke(_existSymbol);
            }
            else {
                if (_dataBaseQueries.TryRemoveAnime<T>(id))
                    SymbolUpdated?.Invoke(_nonExistSymbol);
            }
        }

        public void Update(long id) {
            if (!_dataBaseQueries.CheckIfAnimeExist<T>(id))
                SymbolUpdated?.Invoke(_nonExistSymbol);
            else
                SymbolUpdated?.Invoke(_existSymbol);
        }
    }
}
