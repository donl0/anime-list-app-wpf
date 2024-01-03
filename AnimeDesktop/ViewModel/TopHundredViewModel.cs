﻿using AnimeDesktop.Model;
using AnimeDesktop.Shiki;
using ShikimoriSharp.Classes;
using ShikimoriSharp;
using AnimeDesktop.Commands;

namespace AnimeDesktop.ViewModel
{
    public class TopHundredViewModel : BaseAnimeListViewModel
    {
        public TopHundredViewModel(BaseModel<List<Anime>, ClientShiki, ShikimoriClient> startModel, OpenAnimeWindowCommand openAnime, IShikiImageRuler imageRuler) : base(startModel, openAnime, imageRuler)
        {
        }
    }
}
