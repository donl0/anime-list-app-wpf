namespace AnimeDesktop.Init
{
    internal interface IInitter<TInstance>
    {
        public TInstance Instance { get; }

        public void Init();
        public void Deactivate();
    }
}