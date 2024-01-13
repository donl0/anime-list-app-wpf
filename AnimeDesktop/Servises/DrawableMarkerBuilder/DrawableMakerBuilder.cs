using AnimeDesktop.DataStructure;
using AnimeDesktop.Model;
using AnimeDesktop.Shiki;
using ShikimoriSharp;
using ShikimoriSharp.Classes;

namespace AnimeDesktop.Servises.DrawableMarkerBuilder
{
    public class DrawableMakerBuilder : IDrawableMakerBuilder
    {
        private BaseTakeDataClientPayloaded<AnimeID, ShikimoriClient, long> _animeIDModel;

        public DrawableMakerBuilder(BaseTakeDataClientPayloaded<AnimeID, ShikimoriClient, long> animeIDModel)
        {
            _animeIDModel = animeIDModel;
        }

        public async Task<AnimeDrawable> ToDrawable(Anime anime)
        {

            AnimeID animeID = await _animeIDModel.TakeData(anime.Id);

            AnimeDrawable drawable = new AnimeDrawable(anime.Id, animeID.Name, ToGenresString(animeID.Genres), animeID.Description, anime.Image.Preview, animeID.Episodes, animeID.Score);

            return drawable;
        }

        private string ToGenresString(Genre[] genres)
        {
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
