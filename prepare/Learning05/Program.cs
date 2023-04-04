using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Orange", 3);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
    }
}