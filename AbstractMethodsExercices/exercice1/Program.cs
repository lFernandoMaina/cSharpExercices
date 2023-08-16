using System.Globalization;

var listShapes = new List<Shape>();

Console.Write("Enter the numbers of shapes: ");
var n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    Console.Write($"Shape #{i + 1} data: ");
    Console.Write("Rectangle or Circle? (r, c): ");
    var opc = char.Parse(Console.ReadLine()!);

    Console.Write("Color (Black, Blue, Red): ");
    var color = Enum.Parse<Color>(Console.ReadLine()!);

    if (opc == 'r')
    {
        Console.Write("Widht: ");
        var widht = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Height: ");
        var heigt = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        listShapes.Add(new Rectangle(color, widht, heigt));
    }
    else
    {
        Console.Write("Radius: ");
        var radius = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        listShapes.Add(new Circle(radius, color));
    }
    Console.WriteLine();
}

Console.WriteLine("Shape areas: ");
foreach (Shape shape in listShapes)
{
    Console.WriteLine($"{shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
}


Console.ReadKey();