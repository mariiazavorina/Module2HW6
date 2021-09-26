using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models.DomesticAppliances;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Providers;
using Module2HW6.Services;

namespace Module2HW6
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                            .AddSingleton<IDomesticApplianceProvider, DomesticApplianceProvider>()
                            .AddSingleton<IPluggedInProvider, PluggedInProvider>()
                            .AddTransient<IPowerConsumptionService, PowerConsumptionService>()
                            .AddTransient<ISortService, SortService>()
                            .AddTransient<IPluggedInService, PluggedInService>()
                            .AddTransient<App>()
                            .BuildServiceProvider();

            var appStart = serviceProvider.GetService<App>();
            appStart.Start();
        }
    }
}
