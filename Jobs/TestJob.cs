namespace HangfireDemo.Jobs;

public class TestJob
{
    private readonly ILogger _logger;

    public TestJob(ILogger<TestJob> logger) => _logger = logger;

    public void WriteLog(string logMessage)
    {
        _logger.LogInformation($"{DateTime.Now:yyyy-MM-dd hh:mm:ss tt} {logMessage}");
    }
}
