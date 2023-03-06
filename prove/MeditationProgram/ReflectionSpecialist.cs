using System;
using System.Collections.Generic; 
// The responsibility of the Reflection Specialist is to control events related to the Reflection activity.
public class ReflectionSpecialist : ActivityLeader{
    string _reflectionDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    List<string> _promptList = new List<string>();
    _promptList.Add("Think of a time when you stood up for someone else.");
    _promptList.Add("Think of a time when you did something really difficult.");
    _promptList.Add("Think of a time when you helped someone in need.");
    _promptList.Add("Think of a time when you did something truly selfless.");

    List<string> _questionsList = new List<string>();
    _questionsList.Add("Why was this experience meaningful to you?");
    _questionsList.Add("Have you ever done anything like this before?");
    _questionsList.Add("How did you get started?");
    _questionsList.Add("What made this time different than other times when you were not as successful?");
    _questionsList.Add("What is your favorite thing about this experience?");
    _questionsList.Add("What could you learn from this experience that applies to other situations?");
    _questionsList.Add("What did you learn about yourself through this experience?");
    _questionsList.Add("How can you keep this experience in mind in the future?");

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