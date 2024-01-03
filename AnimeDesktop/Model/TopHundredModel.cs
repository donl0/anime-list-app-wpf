using AnimeDesktop.Shiki;
using ShikimoriSharp;
using ShikimoriSharp.Classes;
using ShikimoriSharp.Settings;

namespace AnimeDesktop.Model
{
    internal class TopHundredModel : BaseModel<List<Anime>, ClientShiki, ShikimoriClient>
    {
        public TopHundredModel(ClientShiki client) : base(client)
        {
        }

        public async override Task<List<Anime>> TakeData()
        {
            var clientInstance = Client.Instance;

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
