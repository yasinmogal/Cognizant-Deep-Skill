using System;

abstract class Shape
{
    public abstract double Area();
}

class Rectangle : Shape
{
    public double Length = 10;
    public double Width = 5;

    public override double Area()
    {
        return Length * Width;
    }
}

class Circle : Shape
{
    public double Radius = 7;

    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }
}

class Program
{
    static void Main()
    {
        Shape rectangle = new Rectangle();
        Shape circle = new Circle();

        Console.WriteLine("Rectangle Area: " + rectangle.Area());

        Console.WriteLine("Circle Area: " + circle.Area());
    }
}