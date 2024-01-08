using Microsoft.AspNetCore.Mvc;

namespace BoronTrotterESayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("AddName/{userName}")]
    public string AddName(string userName)
    {
        return "Hello, " + userName;
    }
}
