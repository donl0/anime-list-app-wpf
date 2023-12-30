using AnimeDesktop.Shiki;
using ShikimoriSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.Model
{
    class AnimeIDModel : IAnimeIDModel
    {
        public async Task<AnimeID> TakeAnime(long id)
        {
            var client = ClientShiki.Instance;

            var anime = await client.Animes.GetAnime(id);

            return anime;
        }
    }
}
