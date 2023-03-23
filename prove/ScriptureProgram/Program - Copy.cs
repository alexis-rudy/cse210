using System;

public class Program
{
    public static void Main(string[] args)
    {
        Scripture scripture;
        Console.WriteLine("Do you want one verse or multiple?");
        string doesUserWantMultipleVerses = Console.ReadLine();
        bool multiple = true;
        if (doesUserWantMultipleVerses.ToLower() == "no")
        {
            multiple = false;
        }
        Reference reference = new Reference();
        scripture = new Scripture(reference.giveReference(multiple));

        string choice = "";
        while(choice != "quit")
        {
            
            // 1. show scripture
            string text = scripture.ToString();
            Console.WriteLine(text);

            // 2. wait for input
            choice = Console.ReadLine();

            // 3. if not quit hide a word
            if (choice != "quit" || choice != "restart")
            {
                scripture.RandomlyHideWord();
            }

            // 4. restore whole thing
            if (choice == "restart")
            {
                scripture.MakeAllWordsVisible();
            }
            if (scripture.CheckAllWordsVisible()){
                Console.WriteLine("You have memorized the scripture!");
            }
        }
    }
}
