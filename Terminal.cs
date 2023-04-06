using System;

public class Terminal{
    // Read parts of the code
    public float ReadFloat(float number){
        number = int.Parse(Console.ReadLine());
        return number;
    }
    public int ReadInt(){
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    public string ReadDate(){
        // Console.WriteLine("Enter the date ");
        string date = Console.ReadLine();
        return date;
    }
    public string ReadInput(string message){
        Console.WriteLine(message);
        return Console.ReadLine();
    }
    // Plain Printing stuff
    public void WelcomeMessage(){
        int choice;
        do{
        Console.WriteLine("Welcome to the Project Keeping Application.");
        Console.WriteLine("What would you like to do:");
        Console.WriteLine("(1) View current projects");
        Console.WriteLine("(2) Add new project");
        Console.WriteLine("(3) Quit");
        Console.Write("> ");
        choice = int.Parse(Console.ReadLine());
        if (choice == 1){
            StorageBin bin = new StorageBin();
            bin.DisplayProjects();
        }
        if (choice == 2){
            CreateNewProject newProject = new CreateNewProject();
            newProject.CreateProject();
        }
        if (choice == 3){
            Console.WriteLine("Have a good day!");
        }
        }while (choice != 3);
    }
    public void WriteMessage(string message){
        Console.WriteLine(message);
    }

    internal void WriteMessage(Project p)
    {
        throw new NotImplementedException();
    }
}