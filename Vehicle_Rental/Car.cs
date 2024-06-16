using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class Car : Vehicle
    {
        public int SafetyRating { get; set; }

        public override decimal GetDailyRentalCost()
        {
            if (RentalDays <= 7)
            {
                return 20m;
            }
            else
            {
                return 15m;
            }
        }

        public override decimal GetDailyInsuranceCost()
        {
            decimal baseCost = 0.0001m * Value;
            if (SafetyRating >= 4)
            {
                baseCost *= 0.9m;
            }
            return baseCost;
        }
    }
}
