using ShikimoriSharp.Classes;

namespace AnimeDesktop.Model
{
    internal interface IAnimeListModel
    {
        public Task<List<Anime>> TakeAnimes();
    }
}