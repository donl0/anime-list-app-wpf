using ShikimoriSharp.Classes;

namespace AnimeDesktop.Servises.DSRuler
{
    public interface IShikiRuler<T>
    {
        public void Rule(T ds);
    }
}