using System;

public class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        int userChoice = Convert.ToInt16(Console.ReadLine());
        if (userChoice == 1){
            // Get a prompt for the user to respond to.
            Prompt prompt = new Prompt();
            string userPrompt = prompt.getRandomPrompt();
            Console.WriteLine($"{userPrompt}");
            // Create an entry to save from the user's response. 
            Entry entry = new Entry();
            string latestEntry = entry.getEntryFromUser();
            // Add the entry to a list for the user to load later. 
            Load loader = new Load();
            loader.addToList(latestEntry);
        }
        else if (userChoice == 2){
            Load loader = new Load();
            loader.showListContents();
        }
        else if (userChoice == 3){
            Files file = new Files();
            file.getFileName();
            string filename = Console.ReadLine();
            Load loader = new Load();
            loader.getEntryList();
        }
    }
}