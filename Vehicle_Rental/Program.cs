using System.Globalization;

namespace Vehicle_Rental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Set culture to en-US to ensure currency format is in dollars
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            // Car example
            Car car = new Car
            {
                Brand = "Mitsubishi",
                Model = "Mirage",
                Value = 15000m,
                SafetyRating = 3,
                RentalDays = 10
            };

            Invoice carInvoice = new Invoice
            {
                Vehicle = car,
                CustomerName = "John Doe",
                ReservationStartDate = new DateTime(2024, 6, 3),
                ReservationEndDate = new DateTime(2024, 6, 13),
                ActualReturnDate = new DateTime(2024, 6, 13),
                ActualRentalDays = 10
            };

            Console.WriteLine("Car Invoice:");
            carInvoice.PrintInvoice();
            Console.WriteLine();

            // Motorcycle example
            Motorcycle motorcycle = new Motorcycle
            {
                Brand = "Triumph",
                Model = "Tiger Sport 660",
                Value = 10000m,
                RiderAge = 20,
                RentalDays = 10
            };

            Invoice motorcycleInvoice = new Invoice
            {
                Vehicle = motorcycle,
                CustomerName = "Mary Johnson",
                ReservationStartDate = new DateTime(2024, 6, 3),
                ReservationEndDate = new DateTime(2024, 6, 13),
                ActualReturnDate = new DateTime(2024, 6, 13),
                ActualRentalDays = 10
            };

            Console.WriteLine("Motorcycle Invoice:");
            motorcycleInvoice.PrintInvoice();
            Console.WriteLine();

            // Cargo Van example
            CargoVan cargoVan = new CargoVan
            {
                Brand = "Citroen",
                Model = "Jumper",
                Value = 20000m,
                DriverExperience = 8,
                RentalDays = 15
            };

            Invoice cargoVanInvoice = new Invoice
            {
                Vehicle = cargoVan,
                CustomerName = "John Markson",
                ReservationStartDate = new DateTime(2024, 6, 3),
                ReservationEndDate = new DateTime(2024, 6, 18),
                ActualReturnDate = new DateTime(2024, 6, 13),
                ActualRentalDays = 10
            };

            Console.WriteLine("Cargo Van Invoice:");
            cargoVanInvoice.PrintInvoice();
            Console.WriteLine();
        }
    }
}