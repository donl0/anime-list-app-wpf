using ShikimoriSharp.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.DataStructure
{
    public class AnimeDrawable
    {
        public string Name { get; }
        public string Genres { get; }
        public string Description { get; set; }
        public string Rating { get; }
        public string Image { get; }
        public long Episodes { get; }

        public AnimeDrawable(string name, string genres, string description, string image, long episodes, string rating)
        {
            Name = name;
            Genres = genres;
            Description = description;
            Image = image;
            Episodes = episodes;
            Rating = rating;
        }
    }
}
