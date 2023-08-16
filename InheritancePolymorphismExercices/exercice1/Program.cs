using System.Globalization;

var listEmployee = new List<Employee>();

Console.Write("Enter the numbers of employees: ");
var numberEmployee = int.Parse(Console.ReadLine()!);

for (int i = 0; i < numberEmployee; i++)
{
    Console.Write($"Enter #{i+1} employee data: ");
    Console.Write("Outsorced? (y/n): ");
    var ch = char.Parse(Console.ReadLine()!);

    Console.Write("Employee name: ");
    var nameEmployee = Console.ReadLine()!;

    Console.Write("Hours: ");
    var hoursEmployee = int.Parse(Console.ReadLine()!);

    Console.Write("Value per hours: ");
    double valuePerHourEmployee = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    if (ch == 'y')
    {
        Console.Write("Additional charge: ");
        var additionalCharge = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        listEmployee.Add(new OutsorcedEmployee(nameEmployee, hoursEmployee, valuePerHourEmployee, additionalCharge));
    }
    else
    {
        listEmployee.Add(new Employee(nameEmployee, hoursEmployee, valuePerHourEmployee));
    }

    Console.Write("\n");
}

Console.Write("\nPayments: \n");
foreach (Employee emp in listEmployee)
{
    Console.Write($"{emp.Name} - ${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
    Console.Write("\n");
}


Console.ReadKey();