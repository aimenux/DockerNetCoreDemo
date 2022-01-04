using Microsoft.AspNetCore.Mvc;

namespace App_03.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet("docker")]
    public string HelloDocker()
    {
        var message = $"Hello Docker at {DateTimeOffset.Now}!";
        _logger.LogTrace($"Starting {nameof(HelloController)}");
        _logger.LogInformation(message);
        _logger.LogTrace($"Stopping {nameof(HelloController)}");
        return message;
    }
}