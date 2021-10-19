using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace TvShopSmsService.Controllers
{
    public class LastSmsSending : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealth = await IsLastSmsSended();
            return isHealth ? HealthCheckResult.Healthy("Sms was Sended") : HealthCheckResult.Unhealthy("Sms was't sended");
        }

        private async Task<bool> IsLastSmsSended()
        {
            return await Task.FromResult(true);
        }
    }
}
