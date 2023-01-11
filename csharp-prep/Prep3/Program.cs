using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        //Game set up
        Console.WriteLine("~Play the guessing game~");
        Console.WriteLine("Guess a number between 1 and 50");
        Console.WriteLine("----------------------------------------");

        //Get random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 50);
        int userGuess;
        int numberOfGuesses = 0;
        string keepGoing = "yes";
        //Loop to keep the game going
        do{
            do 
            {
                Console.Write("Make your guess: ");
                string userInput = Console.ReadLine();
                userGuess = int.Parse(userInput);
                if (userGuess == magicNumber)
                {
                    Console.Write($"You guessed the number in {numberOfGuesses}");

                }else if(userGuess > magicNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Too low!");
                }

                numberOfGuesses++;
            } while (userGuess != magicNumber);
            Console.Write("Play again?");
            keepGoing = Console.ReadLine();
        }while (keepGoing == "yes");
    }
}