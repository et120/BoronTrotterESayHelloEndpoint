using Microsoft.AspNetCore.Mvc;

namespace BoronTrotterESayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    public string greeting = "";

    public SayHelloController()
    {
        greeting = "Hello, ";
    }

    [HttpPost]
    [Route("AddName/{userName}")]
    public string AddName(string userName)
    {
        return greeting + userName;
    }
}
