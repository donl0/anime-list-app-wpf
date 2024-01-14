using System.ComponentModel.DataAnnotations;

namespace AnimeDesktop.DB.Model
{
    public class UserRating : IAnimeHolder
    {
        public int Id { get; set; }

        public long AnimeId { get; set; }

        [Range(0, 10, ErrorMessage = "Value must be between 0 and 10.")]
        public int Rating { get; set; }

    }
}
