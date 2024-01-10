using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnimeDesktop.DB.Model
{
    class AbandonedAnime
    {
        public int Id { get; set; }

        [Key, ForeignKey("Anime")]
        public int AnimeId { get; set; }
    }
}
