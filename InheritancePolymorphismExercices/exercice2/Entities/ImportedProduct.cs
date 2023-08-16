using System.Globalization;

class ImportedProduct : Product
{
    public double CustomsFree { get; set; }

    public ImportedProduct() { }

    public ImportedProduct(String name, double price, double customsFree) : base(name, price)
    {
        CustomsFree = customsFree;
    }

    public double TotalPrice()
    {
        return Price + CustomsFree;
    }

    public override String PriceTag()
    {
        return Name + ", $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
        + " - Tax imported: " + CustomsFree;
    }
}