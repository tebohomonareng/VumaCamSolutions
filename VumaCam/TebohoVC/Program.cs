using System;

// Base class for geometric shapes
public abstract class Shape
{
    // The class has the responsibility of defining the common interface for all shapes (area calculation),
    // adhering to the SRP by having a single reason to change, which is modification in the way areas are calculated.
    public abstract double Area();
}

// Single Responsibility Principle (SRP):
// This class is responsible for calculating the area of a circle, adhering to SRP by having only one reason to change.
public class Circle : Shape
{
    
    public double Radius { get; }

    //Passing the radius input
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Open/Closed Principle (OCP):
    // The Circle class is closed for modification but open for extension.
    // You can easily add new shapes without modifying the existing class.
    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

// Single Responsibility Principle (SRP):
// This class is responsible for calculating the area of a square, adhering to SRP by having only one reason to change.
public class Square : Shape
{
    public double SideLength { get; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    // Open/Closed Principle (OCP):
    // The Sqaure class is closed for modification but open for extension.
    // You can easily add new shapes without modifying the existing class.
    public override double Area()
    {
        return Math.Pow(SideLength, 2);
    }
}

// Single Responsibility Principle (SRP):
// This class is responsible for calculating the area of a triangle, adhering to SRP by having only one reason to change.
public class Triangle : Shape
{
    public double Base { get; }
    public double Height { get; }
    
    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    // Open/Closed Principle (OCP):
    // The Triangle class is closed for modification but open for extension.
    // You can easily add new shapes without modifying the existing class.
    public override double Area()
    {
        return 0.5 * Base * Height;
    }
}

class Program
{
    static void Main()
    {
        //Circle circle = new Circle(radius: 5);
        //Square square = new Square(sideLength: 4);
        //Triangle triangle = new Triangle(@base: 3, height: 6);

        //Console.WriteLine($"Circle Area: {circle.Area()}");
        //Console.WriteLine($"Square Area: {square.Area()}");
        //Console.WriteLine($"Triangle Area: {triangle.Area()}");
    }
}

