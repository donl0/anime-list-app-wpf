using AnimeDesktop.DataStructure;
using AnimeDesktop.Extensions;
using ShikimoriSharp.Classes;
using System.Text.RegularExpressions;

namespace AnimeDesktop.Servises.DSRuler.Description
{
    public class ShikiDescriptionRulerDirector : IShikiRuler<AnimeDrawable>
    {
        public void Rule(AnimeDrawable anime)
        {
            anime.Description = new DescriptionBuilder(anime.Description).WithCharacter().WithAnime().WithITag().WithPerson().Builed();
        }

        class DescriptionBuilder
        {
            private string _ruleObject;

            public DescriptionBuilder(string ruleObject)
            {
                _ruleObject = ruleObject;
            }

            public DescriptionBuilder WithCharacter() {
                _ruleObject = _ruleObject.RemoveString(@"\[character=\d+\]");
                _ruleObject = _ruleObject.RemoveString(@"\[/character]");

                return this;
            }

            public DescriptionBuilder WithAnime()
            {
                _ruleObject = _ruleObject.RemoveString(@"\[anime=\d+\]");
                _ruleObject = _ruleObject.RemoveString(@"\[/anime]");

                return this;
            }

            public DescriptionBuilder WithITag()
            {
                _ruleObject = _ruleObject.RemoveString(@"\[i]");
                _ruleObject = _ruleObject.RemoveString(@"\[/i]");

                return this;
            }

            public DescriptionBuilder WithPerson()
            {
                _ruleObject = _ruleObject.RemoveString(@"\[person=\d+\]");
                _ruleObject = _ruleObject.RemoveString(@"\[/person]");

                return this;
            }

            public string Builed() { 
                return _ruleObject;
            }
        }
    }
}
