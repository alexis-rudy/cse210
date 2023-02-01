using System;
using System.Collections.Generic;

public class PromptGenerator
{

    public string GeneratePrompt()
    {
        List<string> prompts = new List<string>
        //string[] prompts =
            {
                "What color are you feeling today and why?",
                "Write about why you want to write.",
                "What are you looking forward to in a month?",
                "Describe three of your talents.", 
                "What is your favorite book of all time and why?",
                "Write about the five most beautiful moments you've ever seen.", 
                "Make a list of all your core values. How can you live closer to them?"
            };
            Random rnd = new Random();
            int index = rnd.Next(0, prompts.Count);
            string ranPrompt = prompts[index];
        return ranPrompt;
    }
}
