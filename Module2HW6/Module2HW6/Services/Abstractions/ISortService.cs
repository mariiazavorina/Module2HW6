using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models.DomesticAppliances;

namespace Module2HW6.Services.Abstractions
{
    public interface ISortService
    {
        public void Sort(DomesticAppliances[] domesticAppliances);
    }
}
