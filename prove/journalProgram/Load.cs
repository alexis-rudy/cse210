using System;
using System.Collections.Generic;

public class Load{
    public List<string> _allEntries;
    private Dictionary<string, string> database;

    public void getEntries(Dictionary<string, string> database)
    {
        foreach (var item in database.Values)
        {
            _allEntries.Add(item);
        }
    }
}