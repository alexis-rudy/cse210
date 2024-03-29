using System;

public class Program{
    static void Main(string[] args)
    {
        Load loader = new Load();
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        int userChoice = Convert.ToInt16(Console.ReadLine());

        do{
        if (userChoice == 1){
            // Get a prompt for the user to respond to.
            Prompt prompt = new Prompt();
            string userPrompt = prompt.getRandomPrompt();
            Console.WriteLine($"{userPrompt}");
            // Create an entry to save from the user's response. 
            Entry entry = new Entry();
            string userEntry = Console.ReadLine();
            entry.getEntryFromUser(userEntry);
            // Console.WriteLine(userEntry);
            // Add the entry to a list for the user to load later. 
            // Load loader = new Load();
            loader.addToList(userEntry);
        }
        else if (userChoice == 2){
            
            loader.showListContents();
        }
        else if (userChoice == 3){
            Files file = new Files();
            file.getFileName();
            string filename = Console.ReadLine();
            // Load loader = new Load();
            loader.getEntryList();
        }
        else if (userChoice == 4){
            Files file = new Files();
            string filename = file.getFileName();
            file.writeToFile(filename);
        }
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        userChoice = Convert.ToInt16(Console.ReadLine());

        }while(userChoice != 5);
        Console.WriteLine("Thanks for writing!");
    }
}