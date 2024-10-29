using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        //Square square1 = new Square("blue", 5);
        //string square1Color = square1.GetColor();
        //double square1Area = square1.GetArea();

        //Console.WriteLine($"The {square1Color} shape has an area of {square1Area}");

        List<Shape> Shapes = new List<Shape>();

        Square square1 = new Square("blue", 5);
        Shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("red", 6, 5);
        Shapes.Add(rectangle1);

        Circle circle1 = new Circle("Yellow", 8);
        Shapes.Add(circle1);

        foreach (Shape sh in Shapes)
        {

            string color = sh.GetColor();

            double area = sh.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}