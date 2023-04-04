using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        Square square = new Square("Orange", 3);
        Rectangle rectangle = new Rectangle("Red", 8, 2);
        Circle circle = new Circle("Yellow", 4);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape s in shapes){
            s.GetColor();
            s.GetArea();
        }
    }
}