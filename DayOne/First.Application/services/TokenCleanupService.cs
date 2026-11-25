
using First.Application.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace First.Application.Services;

public class TokenCleanupService : BackgroundService
{
    private readonly ILogger<TokenCleanupService> _logger;
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public TokenCleanupService(ILogger<TokenCleanupService> logger, IServiceScopeFactory serviceScopeFactory)
    {
        _logger=logger;
        _serviceScopeFactory=serviceScopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while(!stoppingToken.IsCancellationRequested)
        {
            try
            {
               using var scope=_serviceScopeFactory.CreateScope();

               var repository=scope.ServiceProvider.GetRequiredService<ITokenRepository>();

               await repository.DeleteToken(stoppingToken);

               _logger.LogInformation("Token deleted successfully");

            }
            catch(Exception ex)
            {
                _logger.LogError(ex,"Error while cleaning the token");
            }

            await Task.Delay(TimeSpan.FromHours(24),stoppingToken);
        }

        
    }
}