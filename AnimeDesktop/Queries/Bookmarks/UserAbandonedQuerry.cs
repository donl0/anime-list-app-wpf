using AnimeDesktop.Base;
using ShikimoriSharp.Settings;
using ShikimoriSharp;
using AnimeDesktop.Model;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Queries.Bookmarks
{
    public class UserAbandonedQuerry : BaseTakeDataQuery<List<Anime>, ShikimoriClient>
    {
        public UserAbandonedQuerry(IClient<ShikimoriClient> client) : base(client)
        {
        }

        public async override Task<List<Anime>> TakeData()
        {
            var clientInstance = Client;

            var search = await clientInstance.Animes.GetAnime(new AnimeRequestSettings
            {
                order = ShikimoriSharp.Enums.Order.ranked,
                limit = 1

            });

            List<Anime> anime = search.ToList();

            return anime;
        }
    }
}
