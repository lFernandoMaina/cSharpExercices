using System.Globalization;

class UsedProduct : Product
{
    public DateTime ManufactureDate { get; set; }

    public UsedProduct()
    {
    }

    public UsedProduct(String name, double price, DateTime manufactureDate) : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }

    public override String PriceTag()
    {
        return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + 
        " - Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy");
    }
}