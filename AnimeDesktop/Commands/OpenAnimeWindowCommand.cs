using AnimeDesktop.Servises.DrawableMarkerBuilder;
using AnimeDesktop.Servises.DSRuler.Description;
using AnimeDesktop.View;
using AnimeDesktop.ViewModel;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Commands
{
    public class OpenAnimeWindowCommand : BaseCommand
    {
        private readonly ShikiDescriptionRulerDirector _descriptionRuler;
        private readonly IDrawableMakerBuilder _builder;

        public OpenAnimeWindowCommand(IDrawableMakerBuilder builder, ShikiDescriptionRulerDirector descriptionRuler)
        {
            _descriptionRuler = descriptionRuler;
            _builder = builder;
        }

        public override bool CanExecute(object? parameter)
        {
            return parameter is Anime;
        }

        public override void Execute(object? parameter)
        {
            Anime selectedItem = parameter as Anime;

             CertainAnimeViewModel viewModel = new CertainAnimeViewModel(_builder, selectedItem, _descriptionRuler);
             CertainAnimeView view = new CertainAnimeView()
             {
                 DataContext = viewModel
             };
             view.Show();
        }
    }
}
