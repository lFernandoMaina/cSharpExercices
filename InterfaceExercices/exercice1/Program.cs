using System.Globalization;

Console.Write("Enter rental data: ");
Console.Write("\nCar model: ");
var model = Console.ReadLine()!;

Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
var start = DateTime.Parse(Console.ReadLine()!);

Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
var finish = DateTime.Parse(Console.ReadLine()!);

Console.Write("Enter price hour: ");
double hour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Console.Write("Enter price day: ");
double day = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

var carRental = new CarRental(start, finish, new Vehicle(model));
var RentalService = new RentalService(hour, day, new BrazilTaxService());

RentalService.ProcessInvoice(carRental);
System.Console.WriteLine("Invoice: " + carRental.Invoice);

Console.ReadKey();