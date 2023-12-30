using AnimeDesktop.ViewModel;
using System.Windows;

namespace AnimeDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel viewModel = new MainWindowViewModel();
            DataContext = viewModel;
        }
    }
}