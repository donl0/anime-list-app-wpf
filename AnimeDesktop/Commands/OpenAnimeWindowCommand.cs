using AnimeDesktop.View;
using ShikimoriSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.Commands
{
    class OpenAnimeWindowCommand : BaseCommand
    {
        public override bool CanExecute(object? parameter)
        {
            return parameter is Anime;
        }

        public override void Execute(object? parameter)
        {
            Anime selectedItem = parameter as Anime;

            CertainAnimeView animeView = new CertainAnimeView(selectedItem);

            animeView.Show();
        }
    }
}
