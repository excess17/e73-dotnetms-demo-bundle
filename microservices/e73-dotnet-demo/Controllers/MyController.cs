using Microsoft.AspNetCore.Mvc;

namespace e73_dotnet_demo.Controllers;

[ApiController]
[Route("api")]
public class MyController : ControllerBase
{
    
    private readonly ILogger<MyController> _logger;

    public MyController(ILogger<MyController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("hello")]
    public string GetHello()
    {
        return "Hello world!";
    }
    
    [HttpGet]
    [Route("health")]
    public IActionResult GetHealth()
    {
        var myObject = new {
            Status = "UP"
        };
        return Ok(myObject);
    }
}