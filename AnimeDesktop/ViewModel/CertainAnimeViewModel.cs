using AnimeDesktop.DataStructure;
using AnimeDesktop.Servises.DrawableMarkerBuilder;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Servises.DSRuler.Description;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.ViewModel
{
    public class CertainAnimeViewModel: ICertainAnimeViewModel
    {
        private readonly IShikiRuler<AnimeDrawable> _descriptionRuler;
        private readonly IDrawableMakerBuilder _builder;

        public NotifyTaskCompletion<AnimeDrawable> Value { get; private set; }

        public CertainAnimeViewModel(IDrawableMakerBuilder builder, ShikiDescriptionRulerDirector descriptionRuler)
        {
            _builder = builder;
            _descriptionRuler = descriptionRuler;
        }

        public void Render(Anime anime)
        {
            Action<AnimeDrawable> onTaskCompleted = (anime) => _descriptionRuler.Rule(anime);

            Value = new NotifyTaskCompletion<AnimeDrawable>(Task.Run(async () => await _builder.ToDrawable(anime)), onTaskCompleted);
        }
    }
}

