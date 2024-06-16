using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }
        public int RentalDays { get; set; }

        public abstract decimal GetDailyRentalCost();
        public abstract decimal GetDailyInsuranceCost();
    }
}
