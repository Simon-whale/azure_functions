using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Sorted.DatabaseStats.Interfaces;
using Sorted.DatabaseStats.Services;

[assembly: FunctionsStartup(typeof(Sorted.DatabaseStats.Startup))]
namespace Sorted.DatabaseStats;


public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services.AddSingleton<IThisClass>((s) => { return new ThisClass(); });
    }
}