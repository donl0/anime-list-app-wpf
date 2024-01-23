namespace AnimeDesktop.Model
{
    public interface ITakeDataQueryPayloaded<DS, Payload>
    {
        public Task<DS> TakeDataAsync(Payload payload);
    }
}
