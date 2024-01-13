using AnimeDesktop.Base;
using Microsoft.Extensions.Configuration;
using ShikimoriSharp;
using ShikimoriSharp.Bases;
using System.IO;

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
            string shikiFolder = "Shiki"; ;
            string secretFile = "shikisecrets.json";

            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", shikiFolder, secretFile);
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile(configPath)
                .Build();

            string nameNaming = "ClientName";
            string idNaming = "ClientID";
            string secretNaming = "ClientSecret";

            name = configuration.GetConnectionString(nameNaming);
            id = configuration.GetConnectionString(idNaming);
            secret = configuration.GetConnectionString(secretNaming);
        }
    }
}
