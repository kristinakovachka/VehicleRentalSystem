# Vehicle Rental System

Task : Create a simple C# console application that simulates a vehicle rental system.
It calculates the rental and insurance costs based on specific business rules and generates an invoice for the user.

## Approach

1. I have created an abstract class in order to follow the OOP principles and to reuse/save lines of code. 
Then I created three more classes which inherited and overrid the properties of the abstract base class.
After that I have created another class to hold the calculations logic 
   - `Vehicle` (abstract base class)
   - `Car`, `Motorcycle`, `CargoVan` (inherit from `Vehicle`)
   - `Invoice` (calculates costs and generates the invoice)

2. Business Rules:
   - Daily rental and insurance costs vary by vehicle type and rental duration.
   - Discounts and surcharges apply based on safety rating, rider's age, and driver's experience.
   - If returned early, rental costs are adjusted based on elapsed and remaining days.

## Example

The example in `Program.cs` a client rents John Markson a cargo van `Citroen Jumper` for 15 days but returns it in 10 days. 
The generated invoice displays the total rental and insurance costs.

## How to Run

1. Clone or download this repository.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Build the solution to restore dependencies and compile the project.
4. Run the application. The output will be displayed in the console.

## Requirements

- .NET Core SDK

