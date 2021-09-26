using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Services;
using Module2HW6.Services.Abstractions;
using Module2HW6.Models.DomesticAppliances;
using Module2HW6.Extentions;

namespace Module2HW6.Services
{
    public class SearchByBrandService : SearchService, ISearchService
    {
        public override DomesticAppliances Search(DomesticAppliances[] domesticAppliances, string param)
        {
            DomesticAppliances foundDomesticAppliances = domesticAppliances.SearchByBrand(param);
            return foundDomesticAppliances;
        }
    }
}
