using AnimeDesktop.Base;

namespace AnimeDesktop.DB.Model
{
    class DataBaseQueries
    {
        private IClient<DBClient> _client;

        public DataBaseQueries(IClient<DBClient> client)
        {
            _client = client;
        }
    }
}
