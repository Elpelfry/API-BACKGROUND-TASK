using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Repositories;

namespace BACKGROUND_TASK.Controllers;

[Route("api/admisiones")]
[ApiController]
public class AdmisionesController(ICache<Admisiones> _admisionesCache) : ControllerBase
{
    [HttpGet]
    public IEnumerable<Admisiones> Get()
    {
        return _admisionesCache.ListoOfData!;
    }
}
