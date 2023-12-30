using AnimeDesktop.Base;
using AnimeDesktop.DataStructure;
using AnimeDesktop.Extensions;
using ShikimoriSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.ViewModel
{
    class CertainAnimeViewModel
    {
        public NotifyTaskCompletion<AnimeDrawable> Value { get; private set; }

        public CertainAnimeViewModel(Anime anime)
        {
            Value = new NotifyTaskCompletion<AnimeDrawable>(Task.Run(async () => await anime.ToDrawable()));
        }
    }
}
