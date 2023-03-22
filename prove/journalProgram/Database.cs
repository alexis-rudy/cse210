using System;
using System.Collections.Generic;
public class Database{
    private Dictionary<string, string> _database;

    public Dictionary<string, string> getDatabase(){
        Dictionary<string, string> database;
        database = _database;
        return database;
    }

    public void addToDictionary(string dateKey, string text)
    {
        _database.Add(dateKey, text);
    }
    
    // public string findItem(string date)
    // {
    //     database.
    // }
    
}