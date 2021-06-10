namespace open_closed.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}