using AnimeDesktop.DataStructure;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Extensions
{
    public interface IDrawableMakerBuilder
    {
        Task<AnimeDrawable> ToDrawable(Anime anime);
    }
}