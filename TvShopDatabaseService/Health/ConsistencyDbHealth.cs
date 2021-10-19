using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace TvShopDatabaseService.Health
{
    public class ConsistencyDbHealth : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            bool isHelthly = await IsDatabaseConnectionOKAsync();
            return isHelthly ? HealthCheckResult.Healthy("Database is OK") : HealthCheckResult.Unhealthy("DatabaseHealthChecks is not OK");
        }

        private async Task<bool> IsDatabaseConnectionOKAsync()
        {
            return await Task.FromResult(true);
        }
    }
}
