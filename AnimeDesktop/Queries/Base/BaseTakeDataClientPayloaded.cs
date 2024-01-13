using AnimeDesktop.Base;
using AnimeDesktop.Model.Base;

namespace AnimeDesktop.Model
{
    public abstract class BaseTakeDataClientPayloaded<TDS, TClientType, Payload> : ClientHolder<TClientType>, ITakeDataQueryPayloaded<TDS, Payload>
    {
        protected BaseTakeDataClientPayloaded(IClient<TClientType> client) : base(client)
        {
        }

        public abstract Task<TDS> TakeData(Payload payload);
    }
}
