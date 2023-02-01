using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice;
        do{
        Console.WriteLine("Please select one of the following choices.");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write(">");
        userChoice = int.Parse(Console.ReadLine());
        }while (userChoice != 5);
        
    }
}