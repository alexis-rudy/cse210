using System;
using System.Collections.Generic;
public class Database{
    private Dictionary<string, string> database;

    public void addToDictionary(string dateKey, string text)
    {
        database.Add(dateKey, text);
    }
    // public string findItem(string date)
    // {
    //     datebase.
    // }
    
}