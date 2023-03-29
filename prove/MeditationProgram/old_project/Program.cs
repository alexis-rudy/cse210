// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // menu
//         Console.WriteLine("Menu Options:");
//         Console.WriteLine("1. Start breathing activity");
//         Console.WriteLine("2. Start reflecting activity");
//         Console.WriteLine("3. Start listing activity");
//         Console.WriteLine("4. Quit");
//         Console.WriteLine("Select a choice from the menu: ");
//         int choice = Convert.ToInt16(Console.ReadLine());

//         if (choice == 1){
//             // beginning message
//             Breathing breathing = new Breathing();
//             breathing.printStartMessage("breathing", "this is a description for the breathing class");
//             // start activity

//             //end message
//             breathing.printEndMessage("breathing");
//         }
//         if (choice == 2){
//             // beginning message
//             Reflection reflect = new Reflection();
//             reflect.printStartMessage("reflection", "this is the description for the reflection class")
//             // start activity

//             //end message
//         }
//         if (choice == 3){
//             // beginning message
//             Listing list = new Listing();
//             list.GetStartMessage("listing", "this is the description for the listing class")
//             // start activity

//             //end message
//         }

//     }
// }