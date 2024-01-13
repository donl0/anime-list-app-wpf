using AnimeDesktop.Init;
using AnimeDesktop.Init.DI;
using System.Windows;

namespace AnimeDesktop
{
    public partial class App : Application
    {
        private IInitter _diInitter;

        protected override void OnStartup(StartupEventArgs e)
        {
            _diInitter = new DIInitter();
            _diInitter.Init();

            StartFirstWindow();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

        private void StartFirstWindow() {
            MainWindow = DIInitter.MainWindow;

            MainWindow.Show();
        }
    }
}
