IShape shape = new Circle()
{
    Radius = 2.0,
    Color = Color.White
};

IShape shape2 = new Rectangle()
{
    Widht = 3.5,
    Height = 4.2,
    Color = Color.Black
};

Console.Write(shape);
Console.Write("\n" + shape2);

Console.ReadKey();