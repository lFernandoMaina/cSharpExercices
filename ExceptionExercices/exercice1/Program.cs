using System.Globalization;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
var number = int.Parse(Console.ReadLine()!);

Console.Write("Holder: ");
var holder = Console.ReadLine()!;

Console.Write("Initial balance: ");
var balance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Console.Write("Withdraw limit: ");
var withdrawLimit = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

var account = new Account(number, holder, balance, withdrawLimit);

Console.WriteLine();
Console.Write("Enter amount for withdraw: ");
var amount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
try
{
    account.Withdraw(amount);
    Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}

Console.ReadKey();