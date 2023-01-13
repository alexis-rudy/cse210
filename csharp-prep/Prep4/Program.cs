using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        //Initialize all variables
        List<int> numbers = new List<int>();
        int userNumber;
        int sum = 0;
        int max = 0;
        int count = 0;
        int avg = 0;

        //Get list items from user
        do{
            Console.Write("Enter a number: ");
            string userItem = Console.ReadLine();
            userNumber = int.Parse(userItem);
            //Add userNumber to list
            numbers.Add(userNumber);
            sum += userNumber;
            count++;
            if (userNumber > max)
            {
                max = userNumber;
            }
        } while (userNumber != 0);
        avg = sum/count;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Largest Number: {max}");
    }
}