namespace Shared.Repositories;

public interface ICache<T>
{
    IEnumerable<T>? ListoOfData { get; }

    void Set(IEnumerable<T> data);
}
