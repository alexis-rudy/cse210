class MainProgram
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

        TimerSpecialist timer = new TimerSpecialist();

        while (choice != 4){
            if (choice == 1){
                BreathSpecialist breathe = new BreathSpecialist();
                breathe.GetActivityName("Breathing");
                breathe.WelcomeWithStartMessage();
                breathe.GiveDescriptionOfBreathing();
                timer.AskForDuration();
            }
            else if (choice == 2){
                ReflectionSpecialist reflect = new ReflectionSpecialist();
                reflect.GetActivityName("Reflecting");
                reflect.WelcomeWithStartMessage();
                reflect.GiveReflectionDescription();
                timer.AskForDuration();
                reflect.GiveRandomPrompt();
            }
            else if (choice == 3){
                ListingSpecialist listing = new ListingSpecialist();
                listing.GetActivityName("Listing");
                timer.AskForDuration();
                listing.WelcomeWithStartMessage();
                listing.GiveListingDescription();
            }
        }
        Console.WriteLine("Have a great day!");
    }
}