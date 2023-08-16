class Circle : Shape
{
    public double Radius { get; set; }

    public Circle() { }

    public Circle(double radius, Color color) : base(color)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}