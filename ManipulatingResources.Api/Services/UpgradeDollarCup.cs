using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ManipulatingResources.Api.Contexts;
using Newtonsoft.Json;
using System.Net.Http;

namespace ManipulatingResources.Services
{
    public class UpgradeDollarCup : IHostedService, IDisposable
    {
        public UpgradeDollarCup(IServiceProvider services) => Services = services;

        public IServiceProvider Services;
        private Timer _timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public void Dispose() => _timer?.Dispose();
    }
}