using AnimeDesktop.Base;
using ShikimoriSharp;
using ShikimoriSharp.Classes;
using ShikimoriSharp.Settings;

namespace AnimeDesktop.Model
{
    public class UserWatchedQuery : BaseTakeDataQuery<List<Anime>, ShikimoriClient>
    {
        public UserWatchedQuery(IClient<ShikimoriClient> client) : base(client)
        {
        }

        public async override Task<List<Anime>> TakeData()
        {
            var clientInstance = Client;

            var search = await clientInstance.Animes.GetAnime(new AnimeRequestSettings
            {
                order = ShikimoriSharp.Enums.Order.ranked,
                limit = 4

            });

            List<Anime> anime = search.ToList();

            return anime;
        }
    }
}
