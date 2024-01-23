using AnimeDesktop.Base;
using ShikimoriSharp;
using ShikimoriSharp.Classes;
using ShikimoriSharp.Settings;

namespace AnimeDesktop.Model
{
    internal class TopHundredQuery : BaseTakeDataQuery<List<Anime>, ShikimoriClient>
    {
        public TopHundredQuery(IClient<ShikimoriClient> client) : base(client)
        {
        }

        public async override Task<List<Anime>> TakeDataAsync()
        {
            var clientInstance = Client;

            var search = await clientInstance.Animes.GetAnime(new AnimeRequestSettings
            {
                order = ShikimoriSharp.Enums.Order.ranked,
                limit = 100

            });

            List<Anime> anime = search.ToList();

            return anime;
        }
    }
}
