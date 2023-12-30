using AnimeDesktop.ViewModel;
using ShikimoriSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AnimeDesktop.View
{
    /// <summary>
    /// Interaction logic for CertainAnimeView.xaml
    /// </summary>
    public partial class CertainAnimeView : Window
    {
        public CertainAnimeView(Anime anime)
        {
            CertainAnimeViewModel viewModel = new CertainAnimeViewModel(anime);
            DataContext = viewModel;

            InitializeComponent();
        }
    }
}
