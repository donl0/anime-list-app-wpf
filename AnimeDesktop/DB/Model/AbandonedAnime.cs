namespace AnimeDesktop.DB.Model
{
    public class AbandonedAnime : IAnimeHolder
    {
        public int Id { get; set; }

        public long AnimeId { get; set; }
    }
}
