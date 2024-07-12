using Shared.Models;
using Shared.Repositories;

namespace BACKGROUND_TASK.Services.Admiciones;

public class AdmisionesService(HttpClient _httpcClient) : IApiService<Admisiones>
{
    public async Task<IEnumerable<Admisiones>> GetAll()
    {
        await Task.Delay(TimeSpan.FromMilliseconds(5));
        var response = await _httpcClient.
            GetFromJsonAsync<IEnumerable<Admisiones>>("https://api-rest-proyecto-aplicado.azurewebsites.net/api/Admisiones");
        return response!;
    }
}
