namespace AnimeDesktop.Model
{
    public interface ITakeDataQueryPayloaded<DS, Payload>
    {
        public Task<DS> TakeData(Payload payload);
    }
}
