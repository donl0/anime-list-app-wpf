using AnimeDesktop.View;
using AnimeDesktop.ViewModel;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Model.Commands
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

            _animeViewModel.RenderAsync(selectedItem);
            _animeView.Show();
        }
    }
}
