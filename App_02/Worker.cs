namespace App_02
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogTrace($"Starting {nameof(Worker)}");
                _logger.LogInformation("Hello Docker at {time}!", DateTimeOffset.Now);
                _logger.LogTrace($"Stopping {nameof(Worker)}");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}