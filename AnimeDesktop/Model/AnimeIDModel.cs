using AnimeDesktop.Shiki;
using ShikimoriSharp;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Model
{
    class AnimeIDModel : BasePayloadedModel<AnimeID, ClientShiki, ShikimoriClient, long>
    {
        public AnimeIDModel(ClientShiki client) : base(client)
        {
        }

        public async override Task<AnimeID> TakeData(long id)
        {
            var client = Client.Instance;

            var anime = await client.Animes.GetAnime(id);

            return anime;
        }
    }
}
