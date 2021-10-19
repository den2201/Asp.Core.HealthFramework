using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TvShopDatabaseService.Health
{
    public class DatabaseHealthChecks : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            bool IsHealth = await IsDatabaseConnectionOKAsync();
            return IsHealth ? HealthCheckResult.Healthy("connection OK") : 
                HealthCheckResult.Unhealthy("connection False");
        }

        private async Task<bool> IsDatabaseConnectionOKAsync()
        {
            return await Task.FromResult(DateTime.Now.Millisecond % 2 == 0);
        }
    }
}
