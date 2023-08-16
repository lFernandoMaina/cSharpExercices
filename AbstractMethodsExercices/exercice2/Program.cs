using System.Globalization;

List<Person> list = new List<Person>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine()!);

    Console.Write("Name: ");
    String name = Console.ReadLine()!;

    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    if (type == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        list.Add(new PhysicalPerson(name, income, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine()!);
        list.Add(new LegalPerson(name, income, numberOfEmployees));
    }
}

double sum = 0.0;

Console.WriteLine();
Console.WriteLine("Taxes paid:");
foreach (Person tp in list)
{
    double tax = tp.Tax();
    Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
    sum += tax;
}

Console.WriteLine();
Console.WriteLine("Total taxes: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

Console.ReadKey();