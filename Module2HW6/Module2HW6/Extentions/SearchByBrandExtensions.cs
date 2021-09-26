using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models.DomesticAppliances;

namespace Module2HW6.Extentions
{
    public static class SearchByBrandExtensions
    {
        public static DomesticAppliances SearchByBrand(this DomesticAppliances[] domesticAppliances, string brand)
        {
            DomesticAppliances foundDomesticAppliances = null;
            for (var i = 0; i < domesticAppliances.Length; i++)
            {
                if (domesticAppliances[i].Brand == brand || domesticAppliances[i].Brand.ToLower() == brand)
                {
                    foundDomesticAppliances = domesticAppliances[i];
                    break;
                }
                else
                {
                    i++;
                }
            }

            return foundDomesticAppliances;
        }
    }
}
