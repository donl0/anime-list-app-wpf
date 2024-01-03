using ShikimoriSharp.Classes;

namespace AnimeDesktop.Shiki
{
    class ShikiImageRuler : IShikiImageRuler
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
