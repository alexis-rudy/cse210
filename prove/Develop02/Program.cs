using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;

    }
}
public class Journal
{
    public int displayMenu(){
    Console.WriteLine("Please select one of the following choices.");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write(">");
    int userChoice = int.Parse(Console.ReadLine());
    return userChoice;
    }
    public void Write(){
        public List<string> prompts = new List<string>
        {
            "What color are you feeling today and why?",
            "Write about why you want to write.",
            "What are you looking forward to in a month?",
            "Describe three of your talents.", 
            "What is your favorite book of all time and why?",
            "Write about the five most beautiful moments you've ever seen.", 
            "Make a list of all your core values. How can you live closer to them?"
        };
        prompts
    }
}