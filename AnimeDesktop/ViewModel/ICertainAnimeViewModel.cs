using AnimeDesktop.DataStructure;
using AnimeDesktop.Servises.DrawableMarkerBuilder;
using AnimeDesktop.Servises.DSRuler;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.ViewModel
{
    public interface ICertainAnimeViewModel
    {
        void Render(Anime anime);
    }
}