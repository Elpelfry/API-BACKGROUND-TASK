namespace Shared.Repositories;

public interface IApiService<T>
{
   Task<IEnumerable<T>> GetAll();
}
