using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Models.DomesticAppliances;
using Module2HW6.Enums;
using Module2HW6.Models.DomesticAppliances.LargeHomeAppliances;
using Module2HW6.Models.DomesticAppliances.SmallHouseholdAppliances;
using Module2HW6.Models.DomesticAppliances.SmallHouseholdAppliances.ForHome;
using Module2HW6.Models.DomesticAppliances.SmallHouseholdAppliances.ForKitchen;

namespace Module2HW6.Providers
{
    public class DomesticApplianceProvider : IDomesticApplianceProvider
    {
        public DomesticApplianceProvider()
        {
            DomesticAppliances = new DomesticAppliances[]
            {
                new GasStoves
                {
                    Name = "Плита газовая Gorenje GI5322WF-B",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.A,
                    Brand = "Gorenje",
                    EnergyConsumption = 1.5,
                    NumberOfBurners = 4,
                    GasControlOfBurners = true,
                },
                new ElectricStoves
                {
                    Name = "Плита электрическая CEZARIS ПЭ Н Д 1200-00",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.B,
                    Brand = "Cezaris",
                    EnergyConsumption = 5.5,
                    NumberOfBurners = 4,
                    TypeOfHeatingZones = TypeOfHeatingZones.HighLight,
                },
                new Dishwashers
                {
                    Name = "Посудомоечная машина встраиваемая Bosch SPV2IKX10E",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.A,
                    Brand = "Bosch",
                    EnergyConsumption = 1.7,
                    IsBuiltIn = true,
                    PullOutCulteryBasket = false,
                    VolumeOfConsumedWater = 9.5,
                },
                new Fridges
                {
                    Name = "Холодильник Samsung RB37J5220EF/UA",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.A,
                    Brand = "Samsung",
                    EnergyConsumption = 0.64,
                    IsBuiltIn = false,
                    TypeOfFridge = TypeOfFridge.SideBySide,
                },
                new HVACappliances
                {
                    Name = "Увлажнитель воздуха Philips 2716/10",
                    Brand = "Philips",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.A,
                    EnergyConsumption = 0.034,
                    TypeOfHeating = TypeOfHeating.Water,
                },
                new WashingMachines
                {
                    Name = "Стиральная машина Vestfrost XMV 105 F4",
                    Brand = "Vestfrost",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.A,
                    EnergyConsumption = 147,
                    IsBuiltIn = false,
                    MaximumSpinSpeed = 1000,
                    TypeOfWashingMachine = TypeOfWashingMachine.Frontal,
                },
                new ForKitchen
                {
                    Name = "Мультиварка Tefal Fuzzy logic RK 321A34",
                    Brand = "Tefal",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.A,
                    EnergyConsumption = 0.75,
                    IsPortable = true,
                    TypeOfSmallForKitchen = TypeOfSmallForKitchen.ForFood,
                },
                new ForHome
                {
                    Name = "Пылесос моющий Thomas Sky XT Aqua-Box",
                    Brand = "Thomas",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.B,
                    EnergyConsumption = 0.5,
                    IsPortable = true,
                    TypeOfSmallForHome = TypeOfSmallForHome.HomeCare,
                },
                new ForKitchen
                {
                    Name = "Кофеварка Delonghi ECAM250.33.TB",
                    Brand = "Delonghi",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.A,
                    EnergyConsumption = 1.45,
                    IsPortable = true,
                    TypeOfSmallForKitchen = TypeOfSmallForKitchen.ForDrinks,
                },
                new ForHome
                {
                    Name = "Фен Dyson HD03 Supersonic фуксия",
                    Brand = "Dyson",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.A,
                    EnergyConsumption = 1.6,
                    IsPortable = true,
                    TypeOfSmallForHome = TypeOfSmallForHome.PersonalCare,
                },
                new HVACappliances
                {
                    Name = "Водонагреватель Atlantic Round Eco VMR 80 (1200W)",
                    Brand = "Atlantic",
                    ClassOfEnergyConsumption = ClassOfEnergyConsumption.B,
                    EnergyConsumption = 12,
                    TypeOfHeating = TypeOfHeating.Water
                }
            };
        }

        public DomesticAppliances[] DomesticAppliances { get; }
    }
}
