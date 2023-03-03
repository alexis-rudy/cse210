using System;
using System.Collections.Generic; 
public class ReflectionSpecialist : ActivityLeader{
    string _reflectionDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    List<string> _promptList = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truely selfless."
    ];
    List<string> _questionsList = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?", 
        "How did you get started?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    public void GiveReflectionDescription(){
        Console.WriteLine(_reflectionDescription);
    }
    public void GiveRandomPrompt(){
        Console.WriteLine(_promptList[GetRandomIntPrompt()]);
    }
    public void GiveRandomQuestion(){
        Console.WriteLine(_questionsList[GetRandomIntQuestions()]);
    }
    private int GetRandomIntPrompt(){
        Random rand = new Random();
        int randInt = rand.Next(0, _promptList.Count());
        return randInt;
    }
    private int GetRandomIntQuestions(){
        Random rand = new Random();
        int randInt = rand.Next(0, _questionsList.Count());
        return randInt;
    }
}