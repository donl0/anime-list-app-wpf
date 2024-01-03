using AnimeDesktop.Shiki;

namespace AnimeDesktop.Model
{
    public abstract class BasePayloadedModel<DS, TClientInstance, TClientType, Payload> : IPayloadedModel<DS, Payload> where TClientInstance : IClient<TClientType>
    {
        protected TClientInstance Client;

        public BasePayloadedModel(TClientInstance client)
        {
            Client = client;
        }

        public abstract Task<DS> TakeData(Payload payload);
    }
}
