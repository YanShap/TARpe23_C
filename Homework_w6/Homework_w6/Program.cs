
internal class Circle
{
    private double _radius;
    private double _diameter;

    static void Main(string[] args)
    {
        Circle circle1 = new Circle();
        circle1.PrintInfo();

        circle1.SetRadius(5);

        circle1.CalculateArea();

        Circle circle2 = new Circle(3);
        circle2.PrintInfo();

        circle2.CalculateCircumference();
    }

    public Circle()
    {
        _radius = 0;
        _diameter = 0;
    }

    public Circle(double radius)
    {
        _radius = radius;
        _diameter = radius * 2;
    }

    public void PrintInfo()
    {
        if (_radius == 0 && _diameter == 0)
        {
            Console.WriteLine("Väärtused pole sisestatud!");
        }
        else
        {
            Console.WriteLine($"Ringi raadius on {_radius} ja diameeter on {_diameter}");
        }
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
        _diameter = radius * 2;
        PrintInfo();
    }

    public void SetDiameter(double diameter)
    {
        _diameter = diameter;
        _radius = diameter / 2;
        PrintInfo();
    }

    public void CalculateArea()
    {
        double area = Math.PI * Math.Pow(_radius, 2);
        Console.WriteLine($"Ringi pindala on {area:F2}");
    }

    public void CalculateCircumference()
    {
        double circumference = 2 * Math.PI * _radius;
        Console.WriteLine($"Ringi ümbemõõt on {circumference:F2}");
    }
}