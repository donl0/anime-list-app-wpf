using AnimeDesktop.Base;
using AnimeDesktop.DataStructure;
using AnimeDesktop.Model;
using AnimeDesktop.Servises.DrawableMarkerBuilder;
using AnimeDesktop.Servises.DSRuler;
using AnimeDesktop.Servises.DSRuler.Description;

namespace AnimeDesktop.ViewModel
{
    public class CertainAnimeViewModel : NotifyPropertyChangeHandler, ICertainAnimeViewModel
    {
        private readonly IShikiRuler<AnimeDrawable> _descriptionRuler;
        private readonly IDrawableMakerBuilder _builder;

        private AnimeDrawable _value;

        public AnimeDrawable Value {
            get { 
                return _value;
            } 
            private set
            {
                _value = value;
                OnPropertyChanged();
            }
        }
        public ISymbolBookmarkHolder SymbolBookmarkHolder { get; private set; }

        public CertainAnimeViewModel(IDrawableMakerBuilder builder, ShikiDescriptionRulerDirector descriptionRuler, ISymbolBookmarkHolder symbolBookmarkHolder)
        {
            _builder = builder;
            _descriptionRuler = descriptionRuler;
            SymbolBookmarkHolder = symbolBookmarkHolder;
        }

        public async void Render(ShikimoriSharp.Classes.Anime anime)
        {
            SymbolBookmarkHolder.UpdateAddInListSymbols(anime);

            AnimeDrawable animeDrawable = await Task.Run(() => _builder.ToDrawable(anime));
            _descriptionRuler.Rule(animeDrawable);

            Value = animeDrawable;
        }
    }
}

