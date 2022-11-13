// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SampleBackGroundApp;
using SampleBackGroundApp.Data;
using SampleBackGroundApp.Security;
using SampleBackGroundApp.Service;


CreateHostBuilder(args).Build().Run();
static IHostBuilder CreateHostBuilder(string[] args) =>
         Host.CreateDefaultBuilder(args)
         .ConfigureServices(services =>

                 {
                     services.AddHostedService<ConsumeScopedServiceHostedService>();
                     services.AddSingleton<IUserContext, UserContext>();
                     services.AddSingleton<IUserService, UserService>();
                     services.AddSingleton<IUserRepo, UserRepo>();
                 });