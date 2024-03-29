﻿using AnimeDesktop.Model;
using AnimeDesktop.Model.Commands;
using AnimeDesktop.Servises.DSRuler;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.ViewModel
{
    public class SearchAnimesViewModel: BaseAnimeListViewModel, ISearchModel
    {
        private event Action SearchTextUpdated;

        private readonly AnimeWithNameQuery _querry;

        private string _searchText;


        public SearchAnimesViewModel(ITakeDataQuery<List<Anime>> startQuerry, OpenAnimeWindowCommand openAnime, ShikiImageRuler imageRuler, AnimeWithNameQuery querry) : base(startQuerry, openAnime, imageRuler)
        {
            _querry = querry;
            SearchTextUpdated += OnSearchTextUpdated;
        }

        public void SetSearchText(string value)
        {
            _searchText = value;
            SearchTextUpdated?.Invoke();
        }

        private void OnSearchTextUpdated()
        {
            UpdateWithQuerry(_querry, _searchText);
        }

        protected override void UpdateWithQuerry<String>(ITakeDataQueryPayloaded<List<Anime>, String> querry, String payload)
        {
            base.UpdateWithQuerry(querry, payload);
        }
    }
}
