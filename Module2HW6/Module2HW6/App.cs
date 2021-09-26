using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Providers;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;
using Module2HW6.Services;
using Module2HW6.Models.DomesticAppliances;

namespace Module2HW6
{
    public class App
    {
        private readonly IPluggedInProvider _pluggedInProvider;
        private readonly IPluggedInService _pluggedInService;
        private readonly IPowerConsumptionService _powerConsumptionService;
        private readonly ISortService _sortService;
        public App(IPluggedInProvider pluggedInProvider, IPluggedInService pluggedInService, IPowerConsumptionService powerConsumptionService, ISortService sortService)
        {
            _pluggedInProvider = pluggedInProvider;
            _pluggedInService = pluggedInService;
            _powerConsumptionService = powerConsumptionService;
            _sortService = sortService;
        }

        public void Start()
        {
            _pluggedInService.PluggedIn();
            double totalPowerConsumption = _powerConsumptionService.GetPowerConsumption(_pluggedInProvider.PluggedIn);
            _sortService.Sort(_pluggedInProvider.PluggedIn);
            Console.WriteLine("Plugged in domestic appliances:");
            DisplayDomesticAppliances(_pluggedInProvider.PluggedIn);
            Console.WriteLine($"Total energy consumption: {Math.Round(totalPowerConsumption, 2)} kW/hour");
            Console.WriteLine("Enter the brand you want to search: ");
            var enterBrand = Console.ReadLine();
            var searchByBrandService = new SearchByBrandService();
            var foundDomesticAppliance = searchByBrandService.Search(_pluggedInProvider.PluggedIn, enterBrand);
            if (foundDomesticAppliance != null)
            {
                DisplayDomesticAppliances(foundDomesticAppliance);
            }
            else
            {
                Console.WriteLine("I can`t find this brand!");
            }
        }

        private void DisplayDomesticAppliances(DomesticAppliances[] domesticAppliances)
        {
            foreach (var domesticAppliance in domesticAppliances)
            {
                Console.WriteLine($"Name: {domesticAppliance.Name}, Brand: {domesticAppliance.Brand}, Class of energy consumption: {domesticAppliance.ClassOfEnergyConsumption}, Energy consumption: {domesticAppliance.EnergyConsumption} kW/hour");
            }
        }

        private void DisplayDomesticAppliances(DomesticAppliances domesticAppliance)
        {
            Console.WriteLine($"Name: {domesticAppliance.Name}, Brand: {domesticAppliance.Brand}, Class of energy consumption: {domesticAppliance.ClassOfEnergyConsumption}, Energy consumption: {domesticAppliance.EnergyConsumption} kW/hour");
        }
    }
}
