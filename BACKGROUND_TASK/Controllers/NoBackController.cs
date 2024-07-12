using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Repositories;

namespace BACKGROUND_TASK.Controllers;

[Route("api/back")]
[ApiController]
public class NoBackController(IApiService<Admisiones> service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<Admisiones>> Get()
    {
        return await service.GetAll();
    }
}
