// See https://aka.ms/new-console-template for more information
using System;

public class Shape
{
    public string Name;

    public virtual double CalculateArea() 
    {
        return 0;
    }

}

// circle
public class Circle : Shape
{
    private double Radius;

    public Circle(double Radius){

        this.Radius = Radius;
        
    }

    public override double CalculateArea()
    {
        double Area = Math.PI * Radius * Radius;
        return Area;
    }

}

// Rectangle
public class Rectangle : Shape
{
    private double Width;
    private double Height;

    public Rectangle(double Width, double Height){

        this.Width = Width;
        this.Height = Height;
    }

    public override double CalculateArea()
    {
        double Area = Width * Height;
        return Area;
    }

}

// Triangle
public class Triangle : Shape
{
    private double Base;
    private double Height;
    
    public Triangle(double Base, double Height){

        this.Base = Base;
        this.Height = Height;
    }

    public override double CalculateArea()
    {
        double Area = (Base * Height) / 2;
        return Area;
    }

}

public class Program
{
    public static void PrintShapeArea(Shape shape)
    {
        Console.WriteLine($"Shape: {shape.GetType().Name}");
        Console.WriteLine($"Area: {shape.CalculateArea()}");
    }

    public static void Main(string[] args)
    {
        Circle circle = new Circle(4);
        Rectangle rectangle = new Rectangle(2, 7);
        Triangle triangle = new Triangle(3, 8);

        PrintShapeArea(circle);
        PrintShapeArea(rectangle);
        PrintShapeArea(triangle);
    }
}