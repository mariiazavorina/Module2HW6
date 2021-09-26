using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Enums;

namespace Module2HW6.Models.DomesticAppliances.LargeHomeAppliances
{
    public class Fridges : LargeHomeAppliance
    {
        public TypeOfFridge TypeOfFridge { get; init; }
    }
}
