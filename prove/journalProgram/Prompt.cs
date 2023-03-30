using System;
using System.Collections.Generic;

public class Prompt{
    private List<string> _prompts = new List<string>()
    {
        "How have you served someone today?",
        "If you could be any color, which would you choose and why?",
        "How has your testimony grown in the last few weeks?",
        "List your grievances about the day and how you can change them for the better tomorrow.",
        "Write things that were out of your control today and let them go.",
        "When was the last time someone served you?",
        "Write about your favorite person."
    };
    private int getRandomNumber()
    {
        Random random = new Random();
        int randomNum = random.Next(0, _prompts.Count);
        return randomNum;
    }
    public string getRandomPrompt()
    {
        string prompt = _prompts[getRandomNumber()];
        return prompt;
    }
}