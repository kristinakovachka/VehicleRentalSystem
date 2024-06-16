using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class Motorcycle : Vehicle
    {
        public int RiderAge { get; set; }

        public override decimal GetDailyRentalCost()
        {
            if (RentalDays <= 7)
            {
                return 15m;
            }
            else
            {
                return 10m;
            }
        }

        public override decimal GetDailyInsuranceCost()
        {
            decimal baseCost = 0.0002m * Value;
            if (RiderAge < 25)
            {
                baseCost *= 1.2m;
            }
            return baseCost;
        }
    }
}
