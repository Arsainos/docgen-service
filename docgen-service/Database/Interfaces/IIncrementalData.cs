namespace docgen_service.Database.Interfaces
{
    public interface IIncrementalData<T> where T : class
    {
        public T[] GetData();
    }
}
