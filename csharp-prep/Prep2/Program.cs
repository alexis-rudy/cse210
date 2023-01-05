using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        int grade = 62;
        string letter = "";

        //Determine what the letter grade is based on the percentage.
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Write a message based on whether they passed.
        if (grade > 70)
        {
            Console.WriteLine("Congrats on passing!");
        }
        else
        {
            Console.WriteLine("Don't worry, you can try again!");
        }

        //Print the letter grade to the user.
        Console.Write($"Your grade is: {letter}.");
    }
}