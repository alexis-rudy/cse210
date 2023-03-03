using System;
using System.Collections.Generic;
public class ListingSpecialist : ActivityLeader{

    string _listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    List<string> _promptList = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    
    public void GiveListingDescription(){
        Console.WriteLine(_listingDescription);
    }
    public void GiveRandomQuestion(){
        Console.WriteLine(_promptList[GetRandomInt()]);
    }
    public int GetRandomInt(){
        Random rand = new Random();
        int randInt = rand.Next(0, _promptList.Count());
        return randInt;
    }
}