using AnimeDesktop.Base;

namespace AnimeDesktop.Model.Base
{
    public abstract class ClientHolder<TClientType>
    {
        private readonly IClient<TClientType> _client;

        public TClientType Client => _client.Instance;

        public ClientHolder(IClient<TClientType> client)
        {
            _client = client;
        }
    }
}
