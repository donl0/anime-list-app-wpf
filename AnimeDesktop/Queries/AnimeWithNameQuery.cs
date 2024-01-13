using AnimeDesktop.Shiki;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using ShikimoriSharp.Settings;

namespace AnimeDesktop.Model
{
    public class AnimeWithNameQuery : BaseTakeDataClientPayloaded<List<Anime>, ShikimoriClient, string>
    {
        public AnimeWithNameQuery(ClientShiki client) : base(client)
        {
        }

        public async override Task<List<Anime>> TakeData(string value)
        {
            var clientInstance = Client;

            var search = await clientInstance.Animes.GetAnime(new AnimeRequestSettings
            {
                search = value,
                limit = 100
            });

            List<Anime> anime = search.ToList();

            return anime;
        }
    }
}
