using Shared.Models;
using Shared.Repositories;

namespace BACKGROUND_TASK.Services.Admiciones;

public class AdmisionesCache : ICache<Admisiones>
{
    private IEnumerable<Admisiones>? Admisiones;
    public IEnumerable<Admisiones>? ListoOfData => Admisiones;

    public void Set(IEnumerable<Admisiones> data)
    {
        Interlocked.Exchange(ref Admisiones, data);
    }
}
