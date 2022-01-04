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
        _logger.LogTrace($"Starting {nameof(Service)}");
        _logger.LogInformation("Hello Docker at {time}!", DateTimeOffset.Now);
        _logger.LogTrace($"Stopping {nameof(Service)}");
        return Task.CompletedTask;
    }
}