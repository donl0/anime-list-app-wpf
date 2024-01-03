using AnimeDesktop.Shiki;

namespace AnimeDesktop.Model
{
    public abstract class BaseModel<DS, TClientInstance, TClientType> : IModel<DS> where TClientInstance : IClient<TClientType>
    {
        protected TClientInstance Client;

        public BaseModel(TClientInstance client) {
            Client = client;
        }

        public abstract Task<DS> TakeData();
    }
}
