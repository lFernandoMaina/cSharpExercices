class Rectangle : Shape
{
    public double Widht { get; set; }
    public double Height { get; set; }

    public Rectangle() { }

    public Rectangle(Color color, double widht, double heigt) : base (color)
    {
        Widht = widht;
        Height = heigt;
    }
    public override double Area()
    {
        return Widht * Height;
    }
}