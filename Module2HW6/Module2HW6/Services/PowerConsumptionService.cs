using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Services.Abstractions;
using Module2HW6.Models.DomesticAppliances;

namespace Module2HW6.Services
{
    public class PowerConsumptionService : IPowerConsumptionService
    {
        public double GetPowerConsumption(DomesticAppliances[] domesticAppliances)
        {
            var totalConsumption = 0.0;
            foreach (var domesticAppliance in domesticAppliances)
            {
                totalConsumption += domesticAppliance.EnergyConsumption;
            }

            return totalConsumption;
        }
    }
}
