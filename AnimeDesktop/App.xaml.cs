using AnimeDesktop.Shiki;
using System.Configuration;
using System.Data;
using System.Windows;

namespace AnimeDesktop
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ClientShiki.Init();
        }
    }
}
