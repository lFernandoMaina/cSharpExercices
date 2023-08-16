using System.Globalization;
using System.Text;

class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client? Client { get; set; }
    public List<OrderItem> Products { get; set; } = new List<OrderItem>();

    public Order()
    {
    }

    public void AddItem(OrderItem item)
    {
        Products.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        Products.Remove(item);
    }

    public double Total()
    {
        double sum = 0.0;
        foreach (OrderItem item in Products)
        {
            sum += item.SubTotal();
        }
        return sum;
    }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine("Order status: " + Status);
        sb.AppendLine("Client: " + Client);
        sb.AppendLine("Order items:");
        foreach (OrderItem item in Products)
        {
            sb.AppendLine(item.ToString());
        }
        sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
        return sb.ToString();
    }

}