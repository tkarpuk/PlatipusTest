using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PlatipusTest
{
    public class HelloWorldHostedServiceBack : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Debug.WriteLine("============>>>>>>>> TKA  <<<<<<<<<<===============");
                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}
