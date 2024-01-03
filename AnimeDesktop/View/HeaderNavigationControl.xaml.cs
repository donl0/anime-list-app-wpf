using AnimeDesktop.ViewModel;
using System.Windows.Controls;

namespace AnimeDesktop.View
{
    /// <summary>
    /// Interaction logic for HeaderNavigationControl.xaml
    /// </summary>
    public partial class HeaderNavigationControl : UserControl
    {
        public HeaderNavigationControl()
        {
            var viewModel = new HeaderNavigationViewModel();

            DataContext = viewModel;

            InitializeComponent();
        }
    }
}
