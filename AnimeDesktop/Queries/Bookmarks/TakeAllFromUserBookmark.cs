using AnimeDesktop.Base;
using AnimeDesktop.DB.Model;
using AnimeDesktop.Servises;
using ShikimoriSharp;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Model.Bookmarks
{
    public class TakeAllFromUserBookmark<T> : BaseTakeDataQuery<List<Anime>, ShikimoriClient> where T: class, IAnimeHolder
    {
        private readonly IDataBaseQueries _dbQuerry;
        private readonly AnimeWithIDQuery _animeIDQuery;

        public TakeAllFromUserBookmark(IClient<ShikimoriClient> client, IDataBaseQueries dbQuerry, AnimeWithIDQuery animeIDQuery) : base(client)
        {
            _dbQuerry = dbQuerry;
            _animeIDQuery = animeIDQuery;
        }

        public async override Task<List<Anime>> TakeData()
        {
            List<long> animesId = _dbQuerry.TakeAll<T>();

            List<Anime> animes = new List<Anime>();

            foreach (long id in animesId) {
                AnimeID animeID = await _animeIDQuery.TakeData(id);

                animeID.MakeAnimeType(out Anime anime);

                animes.Add(anime);
            }

            return animes;
        }
    }
}