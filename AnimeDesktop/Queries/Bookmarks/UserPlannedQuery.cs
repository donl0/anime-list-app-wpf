using AnimeDesktop.Base;
using ShikimoriSharp;
using ShikimoriSharp.Classes;
using ShikimoriSharp.Settings;

namespace AnimeDesktop.Model.Bookmarks
{
    class UserPlannedQuery : BaseTakeDataQuery<List<Anime>, ShikimoriClient>
    {
        public UserPlannedQuery(IClient<ShikimoriClient> client) : base(client)
        {
        }

        public async override Task<List<Anime>> TakeData()
        {
            var clientInstance = Client;

            var search = await clientInstance.Animes.GetAnime(new AnimeRequestSettings
            {
                order = ShikimoriSharp.Enums.Order.ranked,
                limit = 10

            });

            List<Anime> anime = search.ToList();

            return anime;
        }
    }
}