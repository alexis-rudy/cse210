using System;
using System.Collections.Generic;

public class Prompt{
    private List<string> _prompts;
    private int getRandomNumber()
    {
        Random random = new Random();
        int randomNum = random.Next(0, _prompts.Count);
        return randomNum;
    }
    public string getRandomPrompt()
    {
        string prompt = _prompts[getRandomNumber()];
    }
}