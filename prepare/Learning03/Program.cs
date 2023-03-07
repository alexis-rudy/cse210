using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        // No number
        Fraction fraction = new Fraction();
        // One number
        Fraction fraction1 = new Fraction(4);
        // Two numbers
        Fraction fraction2 = new Fraction(3, 4);

        // Trying getters and setters
        // Console.WriteLine(fraction.GetTopNumber());
        // Console.WriteLine(fraction1.GetTopNumber());
        // Console.WriteLine(fraction2.GetTopNumber());
        // Console.WriteLine(fraction1.SetTopNumber(3));
        // Console.WriteLine(fraction2.SetTopNumber(3));

        // Running the methods
        Console.WriteLine(fraction.GetFractionView());
    }
}