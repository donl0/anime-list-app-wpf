using AnimeDesktop.Base;
using ShikimoriSharp;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Model
{
    class AnimeIDQuery : BaseTakeDataClientPayloaded<AnimeID, ShikimoriClient, long>
    {
        public AnimeIDQuery(IClient<ShikimoriClient> client) : base(client)
        {
        }

        public async override Task<AnimeID> TakeData(long id)
        {
            var client = Client;

            var anime = await client.Animes.GetAnime(id);

            return anime;
        }
    }
}
