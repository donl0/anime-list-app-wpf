using AnimeDesktop.ViewModel;
using System.Windows;

namespace AnimeDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*            TopHundredViewModel startViewModel = new TopHundredViewModel();
            */
            MainWindowViewModel viewModel = new MainWindowViewModel();
            DataContext = viewModel;
        }
    }
}