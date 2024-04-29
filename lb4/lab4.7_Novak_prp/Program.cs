using System;

abstract class Figure
{
    public abstract double CalculateArea();
    public abstract void Draw();
}

class Rectangle : Figure
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalculateArea()
    {
        return length * width;
    }

    public override void Draw()
    {
        Console.WriteLine($"Rectangle with length {length} and width {width}");
    }
}

class Circle : Figure
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Circle with radius {radius}");
    }
}

class RightTriangle : Figure
{
    private double baseLength;
    private double height;

    public RightTriangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * baseLength * height;
    }

    public override void Draw()
    {
        Console.WriteLine($"Right triangle with base {baseLength} and height {height}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure[] figures = new Figure[3];
        figures[0] = new Rectangle(5, 4);
        figures[1] = new Circle(3);
        figures[2] = new RightTriangle(6, 8);

        foreach (var figure in figures)
        {
            Console.WriteLine($"Area: {figure.CalculateArea()}");
            figure.Draw();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}