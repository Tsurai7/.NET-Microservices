using Microsoft.AspNetCore.Mvc;

namespace  CommandService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlatformsController : Controller
{
    public PlatformsController()
    {

    }

    [HttpPost]
    public IActionResult TestInboundConnection()
    {
        Console.WriteLine("Inbound post #CommandService");
        
        return Ok("Test successful");
    }
}

