using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Services.Abstractions;
using Module2HW6.Models.DomesticAppliances;
using Module2HW6.Helpers;

namespace Module2HW6.Services
{
    public class SortService : ISortService
    {
        public void Sort(DomesticAppliances[] domesticAppliances)
        {
            Array.Sort(domesticAppliances, new PowerConsumptionComparer());
        }
    }
}
