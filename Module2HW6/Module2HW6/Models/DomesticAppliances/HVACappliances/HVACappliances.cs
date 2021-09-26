using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Enums;

namespace Module2HW6.Models.DomesticAppliances
{
    public class HVACappliances : DomesticAppliances
    {
        public TypeOfHeating TypeOfHeating { get; init; }
    }
}
