using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.DomesticAppliances.LargeHomeAppliances
{
    public class Dishwashers : LargeHomeAppliance
    {
        public double VolumeOfConsumedWater { get; init; }
        public bool PullOutCulteryBasket { get; init; }
    }
}
