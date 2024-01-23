using AnimeDesktop.Base;
using ShikimoriSharp;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Model
{
    public class AnimeWithIDQuery : BaseTakeDataClientPayloaded<AnimeID, ShikimoriClient, long>
    {
        public AnimeWithIDQuery(IClient<ShikimoriClient> client) : base(client)
        {
        }

        public async override Task<AnimeID> TakeDataAsync(long id)
        {
            var client = Client;

            var anime = await client.Animes.GetAnime(id);

            return anime;
        }
    }
}
