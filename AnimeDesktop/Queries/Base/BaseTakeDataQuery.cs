using AnimeDesktop.Base;
using AnimeDesktop.Model.Base;

namespace AnimeDesktop.Model
{
    public abstract class BaseTakeDataQuery<TDS, TClientType> : ClientHolder<TClientType>, ITakeDataQuery<TDS> //TO DO: composition
    {
        protected BaseTakeDataQuery(IClient<TClientType> client) : base(client)
        {
        }

        public abstract Task<TDS> TakeData();
    }
}
