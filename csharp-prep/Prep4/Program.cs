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
        double avg = 0.0;
        int smallest_pos = 12345678;

        do{
            //Get list items from user
            Console.Write("Enter a number: ");
            string userItem = Console.ReadLine();
            userNumber = int.Parse(userItem);
            //Add userNumber to list
            numbers.Add(userNumber);
            //Add to sum
            sum += userNumber;
            //Count number
            count++;
            //Check if userNumber is greater than max, to replace max
            if (userNumber > max)
            {
                max = userNumber;
            }
            //Check if userNumber is smaller than smallest_pos to replace smallest_pos
            if (userNumber < smallest_pos && userNumber > 0)
            {
                smallest_pos = userNumber;
            }
        } while (userNumber != 0);
        List<int> sortedList = new List<int>();
        numbers.Sort();
        foreach (int number in numbers)
        {
            sortedList.Add(number);
        }

        avg = sum/count;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Largest Number: {max}");
        Console.WriteLine($"Smallest (positive) number: {smallest_pos}");
        Console.WriteLine($"The sorted list is: {sortedList}");
    }
}