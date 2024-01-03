using AnimeDesktop.Extensions;
using AnimeDesktop.View;
using AnimeDesktop.ViewModel;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Commands
{
    public class OpenAnimeWindowCommand : BaseCommand
    {
        private IDrawableMakerBuilder _builder;

        public OpenAnimeWindowCommand(IDrawableMakerBuilder builder)
        {
            _builder = builder;
        }

        public override bool CanExecute(object? parameter)
        {
            return parameter is Anime;
        }

        public override void Execute(object? parameter)
        {
            Anime selectedItem = parameter as Anime;

             CertainAnimeViewModel viewModel = new CertainAnimeViewModel(_builder, selectedItem);
             CertainAnimeView view = new CertainAnimeView()
             {
                 DataContext = viewModel
             };
             view.Show();
        }
    }
}
