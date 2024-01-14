namespace AnimeDesktop.DB.Model
{
    public class WatchedAnime : IAnimeHolder
    {
        public int Id { get; set; }

        public long AnimeId { get; set; }
    }
}
