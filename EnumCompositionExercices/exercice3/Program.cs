using System.Globalization;

Console.WriteLine("Enter cliente data: ");
Console.Write("Name: ");
var name = Console.ReadLine()!;
Console.Write("Email: ");
var email = Console.ReadLine()!;
Console.Write("Birthday date (DD/MM/YYYY): ");
var birthday = DateTime.Parse(Console.ReadLine()!);

Console.WriteLine("Enter other data: ");
Console.Write("Status (PendingPayment, Processing, Shipped, Delivered): ");
var status = Enum.Parse<OrderStatus>(Console.ReadLine()!);

var client = new Client(name, email, birthday);
var order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? .-----: ");
var n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    var productName = Console.ReadLine()!;
    Console.Write("Product price: ");
    var price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    var product = new Product(productName, price);

    Console.Write("Quantity: ");
    var quantity = int.Parse(Console.ReadLine()!);

    var orderItem = new OrderItem(quantity, price, product);

    order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("Order summary:");
Console.WriteLine(order);

Console.ReadKey();