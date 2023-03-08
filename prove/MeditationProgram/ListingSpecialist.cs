using System;
using System.Collections.Generic;
public class ListingSpecialist : ActivityLeader{

    string _listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    List<string> _promptList = new List<string>(5);
    public ListingSpecialist(){
        _promptList.Add("Who are people that you appreciate?");
        _promptList.Add("What are personal strengths of yours?");
        _promptList.Add("Who are people that you have helped this week?");
        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Who are some of your personal heroes?");
    }  
    public void GiveListingDescription(){
        Console.WriteLine(_listingDescription);
    }
    public void GiveRandomQuestion(){
        Console.WriteLine(_promptList[GetRandomInt()]);
    }
    private int GetRandomInt(){
        Random rand = new Random();
        int randInt = rand.Next(0, _promptList.Count());
        return randInt;
    }
}