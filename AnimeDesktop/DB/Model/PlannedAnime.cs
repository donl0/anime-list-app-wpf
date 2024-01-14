namespace AnimeDesktop.DB.Model
{
    public class PlannedAnime : IAnimeHolder
    {
        public int Id { get; set; }

        public long AnimeId { get; set; }
    }
}
