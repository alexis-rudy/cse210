using System;

public class Program
{
    public static void Main(string[] args)
    {
        Scripture scripture;
        Console.WriteLine("Do you want one verse or multiple?");
        string doesUserWantMultipleVerses = Console.ReadLine();
        if (doesUserWantMultipleVerses.ToLower() == "yes")
        {
            string reference = "John 14:15 If you love me, keep my commandments.";
            scripture = new Scripture(reference);

        }else
        {
            string reference = "Romans 13:8-10 8 Owe no man any thing, but to love one another: for he that loveth another hath fulfilled the law." +
            " 9 For this, Thou shalt not commit adultery, Thou shalt not kill, Thou shalt not steal, Thou shalt not bear false witness, Thou shalt not covet; and if there" +
            " any other commandment, it is briefly comprehended in this saying, namely, Thou shalt love thy neighbor as thyself. 10 Love worketh no ill to his neighbor: therefore love is the fulfilling of the law.";
            scripture = new Scripture(reference);

        }

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
        }
    }
}
