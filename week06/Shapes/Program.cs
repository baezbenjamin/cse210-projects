using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        Rectangle rectangle = new Rectangle("red", 10, 5);
        Circle circle = new Circle("green", 4);

        List<Shape> shapes = new List<Shape>();
        shapes = [];
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}