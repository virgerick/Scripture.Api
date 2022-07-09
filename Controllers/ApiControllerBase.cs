using Microsoft.AspNetCore.Mvc;

namespace Scripture.Api.Controllers
{
    [ApiController]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {

    }
}
