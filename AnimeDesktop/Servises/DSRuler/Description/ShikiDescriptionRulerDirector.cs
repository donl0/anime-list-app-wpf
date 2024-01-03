using AnimeDesktop.DataStructure;

namespace AnimeDesktop.Servises.DSRuler.Description
{
    public partial class ShikiDescriptionRulerDirector : IShikiRuler<AnimeDrawable>
    {
        public void Rule(AnimeDrawable anime)
        {
            IDescriptionBuilder builder = new DescriptionBuilder(anime.Description);
            anime.Description = builder.WithCharacter().WithAnime().WithITag().WithPerson().Builed();
        }
    }
}
