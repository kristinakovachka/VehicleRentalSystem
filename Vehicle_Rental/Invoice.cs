using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    public class Invoice
    {
        public Vehicle Vehicle { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public int ActualRentalDays { get; set; }  // days the vehicle was actually rented

        public decimal CalculateTotalRentalCost()
        {
            decimal totalCost = 0;
            for (int i = 1; i <= ActualRentalDays; i++)
            {
                totalCost += Vehicle.GetDailyRentalCost();
            }

            int remainingDays = Vehicle.RentalDays - ActualRentalDays;
            for (int i = 1; i <= remainingDays; i++)
            {
                totalCost += Vehicle.GetDailyRentalCost() / 2;
            }

            return totalCost;
        }

        public decimal CalculateTotalInsuranceCost()
        {
            return Vehicle.GetDailyInsuranceCost() * ActualRentalDays;
        }

        private decimal CalculateInitialInsurancePerDay()
        {
            decimal initialInsurancePerDay = Vehicle.GetDailyInsuranceCost();
            if (Vehicle is Car)
            {
                initialInsurancePerDay /= 0.9m;
            }
            else if (Vehicle is Motorcycle motorcycle)
            {
                if (motorcycle.RiderAge < 25)
                {
                    initialInsurancePerDay /= 1.2m;
                }
            }
            else if (Vehicle is CargoVan cargoVan)
            {
                if (cargoVan.DriverExperience > 5)
                {
                    initialInsurancePerDay /= 0.85m;
                }
            }
            return initialInsurancePerDay;
        }

        public void PrintInvoice()
        {
            decimal rentalCost = CalculateTotalRentalCost();
            decimal insuranceCost = CalculateTotalInsuranceCost();
            decimal totalCost = rentalCost + insuranceCost;

            decimal initialInsurancePerDay = CalculateInitialInsurancePerDay();
            decimal insuranceDiscountPerDay = initialInsurancePerDay - Vehicle.GetDailyInsuranceCost();

            Console.WriteLine("Rental Invoice:");
            Console.WriteLine($"Date: {DateTime.Now:yyyy-MM-dd}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Rented Vehicle: {Vehicle.Brand} {Vehicle.Model}");
            Console.WriteLine($"Reservation start date: {ReservationStartDate:yyyy-MM-dd}");
            Console.WriteLine($"Reservation end date: {ReservationEndDate:yyyy-MM-dd}");
            Console.WriteLine($"Reserved rental days: {Vehicle.RentalDays}");
            Console.WriteLine($"Actual return date: {ActualReturnDate:yyyy-MM-dd}");
            Console.WriteLine($"Actual rental days: {ActualRentalDays}");
            Console.WriteLine($"Rental cost per day: {Vehicle.GetDailyRentalCost():C2}");
            Console.WriteLine($"Initial insurance per day: {initialInsurancePerDay:C2}");
            Console.WriteLine($"Insurance discount per day: {insuranceDiscountPerDay:C2}");
            Console.WriteLine($"Insurance per day: {Vehicle.GetDailyInsuranceCost():C2}");
            Console.WriteLine($"Early return discount for rent: {Vehicle.GetDailyRentalCost() / 2:C2}");
            Console.WriteLine($"Early return discount for insurance: {Vehicle.GetDailyInsuranceCost():C2}");
            Console.WriteLine($"Total rent: {rentalCost:C2}");
            Console.WriteLine($"Total Insurance: {insuranceCost:C2}");
            Console.WriteLine($"Total: {totalCost:C2}");
        }
    }

}
