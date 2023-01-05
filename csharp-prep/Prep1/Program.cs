using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep1 World!");
        //Opening title
        Console.WriteLine("'Bond' Your Name!");
        Console.WriteLine("---------------------------------");

        //Get user's first name and save it in a variable.
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        
        //Get user's last name and save it in a variable.
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        //Return the user's name in 'Bond' format.
        Console.WriteLine();
        Console.Write($"Your name is {lname}, {fname} {lname}.");
    }
}