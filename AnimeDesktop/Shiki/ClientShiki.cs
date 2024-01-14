using AnimeDesktop.Base;
using AnimeDesktop.Secrets;
using ShikimoriSharp;
using ShikimoriSharp.Bases;

namespace AnimeDesktop.Shiki
{
    public class ClientShiki : IClient<ShikimoriClient>
    {
        public ShikimoriClient Instance { get; private set; }

        public ClientShiki() {
            Init();
        }

        private void Init() {
            if (Instance == null)
            {
                TakeConnectionInfo(out string name, out string id, out string secter);

                Instance = new ShikimoriClient(null, 
                    new ClientSettings(
                     name,
                     id,
                     secter));

                return;
            }

            string errorMessage = "Instance is already created.";

           throw new InvalidOperationException(errorMessage);
        }

        private void TakeConnectionInfo(out string name, out string id, out string secret) {
            ShikiConnection connection = new ShikiConnection();
            name = connection.Name;
            id = connection.Id;
            secret = connection.Secret;
        }
    }
}
