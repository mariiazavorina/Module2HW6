using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Enums;

namespace Module2HW6.Models.DomesticAppliances
{
    public class DomesticAppliances
    {
        public string Name { get; init; }
        public ClassOfEnergyConsumption ClassOfEnergyConsumption { get; init; }
        public string Brand { get; init; }
        public double EnergyConsumption { get; init; }
    }
}
