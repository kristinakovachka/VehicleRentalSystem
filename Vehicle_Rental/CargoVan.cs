using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class CargoVan : Vehicle
    {
        public int DriverExperience { get; set; }

        public override decimal GetDailyRentalCost()
        {
            if (RentalDays <= 7)
            {
                return 50m;
            }
            else
            {
                return 40m;
            }
        }

        public override decimal GetDailyInsuranceCost()
        {
            decimal baseCost = 0.0003m * Value;
            if (DriverExperience > 5)
            {
                baseCost *= 0.85m;
            }
            return baseCost;
        }
    }
}
