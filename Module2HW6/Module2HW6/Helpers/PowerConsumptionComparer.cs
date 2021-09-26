using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Module2HW6.Models.DomesticAppliances;

namespace Module2HW6.Helpers
{
    public class PowerConsumptionComparer : IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            var domesticAppliance1 = obj1 as DomesticAppliances;
            var domesticAppliance2 = obj2 as DomesticAppliances;

            if (domesticAppliance1.EnergyConsumption > domesticAppliance2.EnergyConsumption)
            {
                return 1;
            }
            else if (domesticAppliance1.EnergyConsumption < domesticAppliance2.EnergyConsumption)
            {
                return -1;
            }

            return 0;
        }
    }
}
