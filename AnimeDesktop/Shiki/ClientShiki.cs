using ShikimoriSharp;
using ShikimoriSharp.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.Shiki
{
    class ClientShiki
    {
        const string ClientName = "Anime Burger";
        const string ClientID = "ZEv-jFeYK_wdHhI8KY86_OcfKma66hy80aQ91MOICs4";
        const string ClientSecret = "Im_G_ndXFnnMtzIBKydYW9b3UsRSZU7Lfa6oUmzyzKI";

        private static ShikimoriClient? Instance;

        public static void Init() {
            if (Instance == null)
            {
                Instance = new ShikimoriClient(null, new ClientSettings(ClientName, ClientID, ClientSecret));
                return;
            }

           throw new InvalidOperationException("Singleton instance is already created.");
        }


    }
}
