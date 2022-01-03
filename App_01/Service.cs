using Microsoft.Extensions.Logging;

namespace App_01;

public interface IService
{
    Task RunAsync();
}

public class Service : IService
{
    private readonly ILogger<Service> _logger;

    public Service(ILogger<Service> logger)
    {
        _logger = logger;
    }

    public Task RunAsync()
    {
        _logger.LogTrace($"Starting {nameof(RunAsync)}");
        _logger.LogInformation("Hello Docker !");
        _logger.LogTrace($"Stopping {nameof(RunAsync)}");
        return Task.CompletedTask;
    }
}