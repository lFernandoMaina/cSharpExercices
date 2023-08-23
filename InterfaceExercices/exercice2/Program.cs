using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
var contractNumber = int.Parse(Console.ReadLine()!);

Console.Write("Date (dd/MM/yyyy): ");
var contractDate = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.Write("Contract value: ");
var contractValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Console.Write("Enter number of installments: ");
var months = int.Parse(Console.ReadLine()!);

var myContract = new Contract(contractNumber, contractDate, contractValue);

var contractService = new ContractService(new PaypalService());
contractService.ProcessContract(myContract, months);

Console.WriteLine("Installments:");
foreach (Installment installment in myContract.Installments)
{
    Console.WriteLine(installment);
    Console.ReadKey();
}