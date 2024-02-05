using System;

class Program
{
    static void Main(string[] args)
    {
        Square newSquare = new Square("red", 3);
        Rectangle newRectangle = new Rectangle("blue", 3, 5);
        Circle newCircle = new Circle("pink", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(newSquare);
        shapes.Add(newCircle);
        shapes.Add(newRectangle);

        foreach(Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
            Console.WriteLine("--°--");
        }

    }
}