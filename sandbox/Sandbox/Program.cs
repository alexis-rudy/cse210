using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        //Write an if statement
        int x = 1;
        int y = 3;
        int e = 8;
        if (x > y)
        {
            Console.WriteLine("x is bigger");
        }
        else if (e > x)
        {
            Console.WriteLine("e is bigger");
            Console.BackgroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.WriteLine("y is bigger");
        }
    }
}