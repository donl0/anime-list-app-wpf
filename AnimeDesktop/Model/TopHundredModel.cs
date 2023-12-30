using AnimeDesktop.Shiki;
using ShikimoriSharp.Classes;
using ShikimoriSharp.Settings;

namespace AnimeDesktop.Model
{
    internal class TopHundredModel : IAnimeListModel
    {
        public async Task<List<Anime>> TakeAnimes()
        {
            var client = ClientShiki.Instance;

            var search = await client.Animes.GetAnime(new AnimeRequestSettings
            {
                order = ShikimoriSharp.Enums.Order.ranked,
                limit = 100

            });

            List<Anime> anime = search.ToList();

            return anime;
        }
    }
}
