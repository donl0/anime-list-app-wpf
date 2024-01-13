namespace AnimeDesktop.DataStructure
{
    public class AnimeDrawable
    {
        public long Id { get; }
        public string Name { get; }
        public string Genres { get; }
        public string Description { get; set; }
        public string Rating { get; }
        public string Image { get; }
        public long Episodes { get; }

        public AnimeDrawable(long id, string name, string genres, string description, string image, long episodes, string rating)
        {
            Id = id;
            Name = name;
            Genres = genres;
            Description = description;
            Image = image;
            Episodes = episodes;
            Rating = rating;
        }
    }
}
