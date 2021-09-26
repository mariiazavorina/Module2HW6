using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Services.Abstractions;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Models.DomesticAppliances;

namespace Module2HW6.Services
{
    public class PluggedInService : IPluggedInService
    {
        private readonly IDomesticApplianceProvider _domesticApplianceProvider;
        private readonly IPluggedInProvider _pluggedInProvider;
        public PluggedInService(IDomesticApplianceProvider domesticApplianceProvider, IPluggedInProvider pluggedInProvider)
        {
            _domesticApplianceProvider = domesticApplianceProvider;
            _pluggedInProvider = pluggedInProvider;
        }

        public void PluggedIn()
        {
            DomesticAppliances[] domesticAppliances = new DomesticAppliances[6];
            for (var i = 0; i < domesticAppliances.Length; i++)
            {
                domesticAppliances[i] = _domesticApplianceProvider.DomesticAppliances[new Random().Next(0, 11)];
                _pluggedInProvider.PluggedIn = domesticAppliances;
            }
        }
    }
}
