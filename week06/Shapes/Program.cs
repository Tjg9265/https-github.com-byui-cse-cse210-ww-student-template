using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add shapes to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 10));
        shapes.Add(new Circle("Green", 3));

        // Loop through and display color + area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}
