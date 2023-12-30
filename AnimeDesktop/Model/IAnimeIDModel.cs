using ShikimoriSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.Model
{
    internal interface IAnimeIDModel
    {
        public Task<AnimeID> TakeAnime(long id);
    }
}
