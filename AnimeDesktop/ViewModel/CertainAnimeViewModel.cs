using AnimeDesktop.DataStructure;
using AnimeDesktop.Servises.DrawableMarkerBuilder;
using AnimeDesktop.Servises.DSRuler;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.ViewModel
{
    public class CertainAnimeViewModel
    {
        private IDrawableMakerBuilder _builder;
        private readonly IShikiRuler<AnimeDrawable> _descriptionRuler;

        public NotifyTaskCompletion<AnimeDrawable> Value { get; private set; }

        public CertainAnimeViewModel(IDrawableMakerBuilder builder, Anime anime, IShikiRuler<AnimeDrawable> descriptionRuler)
        {
            _builder = builder;
            _descriptionRuler = descriptionRuler;
            Render(builder, anime, _descriptionRuler);
        }

        private void Render(IDrawableMakerBuilder builder, Anime anime, IShikiRuler<AnimeDrawable> descriptionRuler)
        {
            Action<AnimeDrawable> onTaskCompleted = (anime) => descriptionRuler.Rule(anime);

            Value = new NotifyTaskCompletion<AnimeDrawable>(Task.Run(async () => await builder.ToDrawable(anime)), onTaskCompleted);
        }
    }
}

