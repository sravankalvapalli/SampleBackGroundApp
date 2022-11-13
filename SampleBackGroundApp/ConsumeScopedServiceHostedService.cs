using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SampleBackGroundApp.Security;
using SampleBackGroundApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackGroundApp
{
    public class ConsumeScopedServiceHostedService : BackgroundService
    {
        private readonly ILogger<ConsumeScopedServiceHostedService> _logger;

        public ConsumeScopedServiceHostedService(IServiceProvider services,
            ILogger<ConsumeScopedServiceHostedService> logger)
        {
            Services = services;
            //_userService = userService;
            _logger = logger;
        }

        public IServiceProvider Services { get; }

        //private readonly IUserService _userService;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Consume Scoped Service Hosted Service running.");

            await DoWork(stoppingToken);
        }

        private async Task DoWork(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Consume Scoped Service Hosted Service is working.");

            while (true)
            {
                var content = Console.ReadLine();
                if(content != String.Empty)
                {
                    int userId = Convert.ToInt32(content);
                    using (var scope = Services.CreateScope())
                    {
                        var usercontext = scope.ServiceProvider.GetRequiredService<IUserContext>();
                        usercontext.SetUserId(userId);

                        var userserive = scope.ServiceProvider.GetRequiredService<IUserService>();

                        Console.WriteLine(await userserive.GetUserName());
                    }
                    //Console.WriteLine(await _userService.GetUserName());
                }
               
            }

          
        }

        public override async Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation(
                "Consume Scoped Service Hosted Service is stopping.");

            await base.StopAsync(stoppingToken);
        }
    }
}
