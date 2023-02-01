public class Journal{
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

    public string getJournalPrompt(List<string> promptList){
        Random random = new Random();
        string prompt = promptList[random.Next(0, prompts.Count)];
        return prompt;
    }
    
    public string writeJournalEntry(){
        Console.WriteLine("> ");
        string entry = Console.ReadLine();
        return entry;
    }
}