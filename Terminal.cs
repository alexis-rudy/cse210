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
        Console.WriteLine("Enter the date (format: Jan 1, 2000): ");
        string date = Console.ReadLine();
        return date;
    }
    public string ReadInput(string message){
        Console.WriteLine(message);
        return Console.ReadLine();
    }
    // Plain Printing stuff
    public void WelcomeMessage(){
        Console.WriteLine("Welcome to the Project Keeping Application.");
        Console.WriteLine("What would you like to do:");
        Console.WriteLine("(1) View current projects");
        Console.WriteLine("(2) Add new project");
        Console.WriteLine("(3) Delete project");
        Console.Write("> ");
    }
    public void WriteMessage(string message){
        Console.WriteLine(message);
    }
}