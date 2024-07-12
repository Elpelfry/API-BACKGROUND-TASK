using Shared.Models;
using Shared.Repositories;

namespace BACKGROUND_TASK.Services.Admiciones;

public class BackgroundTaskAdmisiones
    (IServiceProvider _serviveProvider, ICache<Admisiones> AdmisionesCache ) : BackgroundService
{
    public async override Task StartAsync(CancellationToken cancellationToken)
    {
        await UpdateCache();
        await base.StartAsync(cancellationToken);
    }

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromSeconds(25), stoppingToken);
            await UpdateCache();
        }
    }

    private async Task UpdateCache()
    {
        using(var scope = _serviveProvider.CreateScope())
        {
            Console.WriteLine("Background task Admisiones is running.");
            var service = scope.ServiceProvider.GetRequiredService<IApiService<Admisiones>>();
            var data = await service.GetAll();
            AdmisionesCache.Set(data);
        }
    }
}
