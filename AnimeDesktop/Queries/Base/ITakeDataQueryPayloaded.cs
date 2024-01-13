namespace AnimeDesktop.Model
{
    internal interface ITakeDataQueryPayloaded<DS, Payload>
    {
        public Task<DS> TakeData(Payload payload);
    }
}
