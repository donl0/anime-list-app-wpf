using ShikimoriSharp;
using ShikimoriSharp.Bases;

namespace AnimeDesktop.Shiki
{
    public class ClientShiki : IClient<ShikimoriClient>
    {
        const string ClientName = "Anime Burger";
        const string ClientID = "ZEv-jFeYK_wdHhI8KY86_OcfKma66hy80aQ91MOICs4";
        const string ClientSecret = "Im_G_ndXFnnMtzIBKydYW9b3UsRSZU7Lfa6oUmzyzKI";

        public ShikimoriClient Instance { get; private set; }

        public ClientShiki() {
            Init();
        }

        private void Init() {
            if (Instance == null)
            {
                Instance = new ShikimoriClient(null, new ClientSettings(ClientName, ClientID, ClientSecret));
                return;
            }

            string errorMessage = "Instance is already created.";

           throw new InvalidOperationException(errorMessage);
        }
    }
}
