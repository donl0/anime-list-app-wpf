using AnimeDesktop.View;
using AnimeDesktop.ViewModel;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Commands
{
    public class OpenAnimeWindowCommand : BaseCommand
    {
        private readonly ICertainAnimeViewModel _animeViewModel;
        private readonly CertainAnimeView _animeView;


        public OpenAnimeWindowCommand(CertainAnimeView animeView, ICertainAnimeViewModel animeViewModel)
        {
            _animeView = animeView;
            _animeViewModel = animeViewModel;
        }

        public override bool CanExecute(object? parameter)
        {
            return parameter is Anime;
        }

        public override void Execute(object? parameter)
        {
            Anime selectedItem = parameter as Anime;

            /*CertainAnimeViewModel viewModel = new CertainAnimeViewModel(_builder, selectedItem, _descriptionRuler);
            CertainAnimeView view = new CertainAnimeView()
            {
                DataContext = viewModel
            };*/
            _animeViewModel.Render(selectedItem);
            _animeView.Show();
        }
    }
}
