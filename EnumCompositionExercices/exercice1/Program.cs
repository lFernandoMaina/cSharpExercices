using System.Globalization;

Console.Write("Enter department's name: ");
var deptName = Console.ReadLine()!;

Console.Write("Name: ");
var name = Console.ReadLine()!;

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()!);

Console.Write("Base salary: ");
var baseSalary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);


var dept = new Department(deptName);
var worker = new Worker(name, level, baseSalary, dept);

Console.Write("How many contracts to this worker? .----: ");
var n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data: ");
    Console.Write("Date (DD/MM/YYYY): ");
    var date = DateTime.Parse(Console.ReadLine()!);

    Console.Write("Value per hour: ");
    var valuePerHour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Duration (hours): ");
    var hours = int.Parse(Console.ReadLine()!);

    var contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}

Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
var monthAndYear = Console.ReadLine()!;
var month = int.Parse(monthAndYear.Substring(0, 2));
var year = int.Parse(monthAndYear.Substring(3));

Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department);
Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

Console.ReadKey();