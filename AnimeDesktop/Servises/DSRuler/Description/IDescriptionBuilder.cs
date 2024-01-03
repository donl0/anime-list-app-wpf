namespace AnimeDesktop.Servises.DSRuler.Description
{
    internal interface IDescriptionBuilder
    {
        string Builed();
        public DescriptionBuilder WithAnime();
        public DescriptionBuilder WithCharacter();
        public DescriptionBuilder WithITag();
        public DescriptionBuilder WithPerson();
    }
}