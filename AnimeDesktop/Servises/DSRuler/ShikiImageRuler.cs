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

                anime.Image.Preview = SHIKIURL + anime.Image.Preview;
            }
        }
    }
}
