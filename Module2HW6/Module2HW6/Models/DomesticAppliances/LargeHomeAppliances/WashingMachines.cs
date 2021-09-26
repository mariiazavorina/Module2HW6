using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Enums;

namespace Module2HW6.Models.DomesticAppliances.LargeHomeAppliances
{
    public class WashingMachines : LargeHomeAppliance
    {
        public TypeOfWashingMachine TypeOfWashingMachine { get; init; }
        public int MaximumSpinSpeed { get; init; }
    }
}
