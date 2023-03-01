using System;

class Program
{
    static void Main(string[] args)
    {
        // menu
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        int choice = Convert.ToInt16(Console.ReadLine());

        if (choice == 1){
            // beginning message
            Breathing breathing = new Breathing();
            breathing.printStartMessage("breathing", "this is a description");
            // start activity

            //end message
            breathing.printEndMessage("breathing");
        }
        if (choice == 2){
            // beginning message

            // start activity

            //end message
        }
        if (choice == 3){
            // beginning message

            // start activity

            //end message
        }

    }
}