using ShikimoriSharp.Classes;

namespace AnimeDesktop.Servises.DSRuler
{
    public class ShikiImageRuler : IShikiRuler<List<Anime>>
    {
        public void Rule(List<Anime> animes)
        {
            foreach (Anime anime in animes)
            {
                const string SHIKIURL = "https://shikimori.one";
                anime.Image.Original = SHIKIURL + anime.Image.Original;
                anime.Image.X96 = SHIKIURL + anime.Image.X96;
                anime.Image.X48 = SHIKIURL + anime.Image.X48;
                anime.Image.Preview = SHIKIURL + anime.Image.Preview;
            }
        }
    }
}
