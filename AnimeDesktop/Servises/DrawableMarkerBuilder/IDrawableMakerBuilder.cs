using AnimeDesktop.DataStructure;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Servises.DrawableMarkerBuilder
{
    public interface IDrawableMakerBuilder
    {
        Task<AnimeDrawable> ToDrawable(Anime anime);
    }
}