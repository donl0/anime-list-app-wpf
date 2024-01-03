using AnimeDesktop.DataStructure;
using AnimeDesktop.Extensions;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.ViewModel
{
    public class CertainAnimeViewModel
    {
        private IDrawableMakerBuilder _builder;
        public NotifyTaskCompletion<AnimeDrawable> Value { get; private set; }

        public CertainAnimeViewModel(IDrawableMakerBuilder builder, Anime anime)
        {
            _builder = builder;

            Render(builder, anime);
        }

        private void Render(IDrawableMakerBuilder builder, Anime anime)
        {
            Value = new NotifyTaskCompletion<AnimeDrawable>(Task.Run(async () => await builder.ToDrawable(anime)));
        }
    }
}

