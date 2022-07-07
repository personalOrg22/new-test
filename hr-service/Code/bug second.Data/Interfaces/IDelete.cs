namespace bug second.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
