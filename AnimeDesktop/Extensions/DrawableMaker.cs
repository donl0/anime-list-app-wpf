using AnimeDesktop.DataStructure;
using AnimeDesktop.Model;
using ShikimoriSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDesktop.Extensions
{
    public static class DrawableMaker
    {
        public static async Task<AnimeDrawable> ToDrawable(this Anime anime) {
            IAnimeIDModel animeIDModel = new AnimeIDModel();

            AnimeID animeID = await animeIDModel.TakeAnime(anime.Id);

            AnimeDrawable drawable = new AnimeDrawable(animeID.Name, ToGenresString(animeID.Genres), animeID.Description, anime.Image.Preview, animeID.Episodes, animeID.Score);

            return drawable;
        }

        private static string ToGenresString(Genre[] genres) {
            string genresString = "";
            string splitter = " ,";

            for (int i = 0; i < genres.Length; i++)
            {
                genresString += genres[i].Name;

                if (i < genres.Length - 1)
                {
                    genresString += splitter;
                }
            }

            return genresString;
        }
    }
}
