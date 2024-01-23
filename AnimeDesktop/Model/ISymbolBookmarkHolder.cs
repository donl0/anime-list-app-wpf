using AnimeDesktop.DB.Model;
using AnimeDesktop.Model.SymbolJob;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Model
{
    public interface ISymbolBookmarkHolder
    {
        SymbolBookmarkModel<AbandonedAnime> AbandonedModel { get; }

        void UpdateAddInListSymbolsAsync(Anime anime);
    }
}