using ShikimoriSharp.Classes;

namespace AnimeDesktop.Servises
{
    public static class TypeMaker
    {
        public static AnimeID MakeAnimeType(this AnimeID animeID, out Anime anime)
        {
            anime = new Anime
            {
                Id = animeID.Id,
                Name = animeID.Name,
                Russian = animeID.Russian,
                Image = animeID.Image,
                Url = animeID.Url,
                Kind = animeID.Kind,
                Score = animeID.Score,
                Status = animeID.Status,
                AiredOn = animeID.AiredOn,
                ReleasedOn = animeID.ReleasedOn,
                Episodes = animeID.Episodes,
                EpisodesAired = animeID.EpisodesAired
            };

            return animeID;
        }
    }
}
