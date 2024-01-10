using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeDesktop.DB.Model
{
    class UserRating
    {
        public int Id { get; set; }

        [Key, ForeignKey("Anime")]
        public int AnimeId { get; set; }

        [Range(0, 10, ErrorMessage = "Value must be between 0 and 10.")]
        public int Rating { get; set; }

    }
}
