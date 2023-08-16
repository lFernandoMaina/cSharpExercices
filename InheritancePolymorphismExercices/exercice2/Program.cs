using System.Globalization;

var listProduct = new List<Product>();

Console.Write("Enter the number of products: ");
var numberProducts = int.Parse(Console.ReadLine()!);

for (int i = 0; i < numberProducts; i++)
{
    Console.WriteLine($"Product #{i + 1} data:");
    Console.Write("Commom, using or imported? (c, u, i): ");
    var type = char.Parse(Console.ReadLine()!);

    Console.Write("Name: ");
    String name = Console.ReadLine()!;
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    if (type == 'c')
    {
        listProduct.Add(new Product(name, price));
    }
    else if (type == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine()!);
        listProduct.Add(new UsedProduct(name, price, date));
    }
    else
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        listProduct.Add(new ImportedProduct(name, price, customsFee));
    }
    Console.WriteLine(" ");
}

Console.WriteLine();
Console.WriteLine("Price tags: ");
foreach (Product prod in listProduct)
{
    Console.WriteLine(prod.PriceTag());
}

Console.ReadKey();