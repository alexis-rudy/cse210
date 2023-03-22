using System;
using System.Collections.Generic;

public class Load{
    private List<string> _allEntries;
    // private Dictionary<string, string> database;

    public List<string> getEntryList(){
        List<string> entryList;
        entryList = _allEntries;
        return entryList;
    }
    public void getEntries(Dictionary<string, string> database)
    {
        foreach (var item in database.Values)
        {
            _allEntries.Add(item);
        }
    }
    public void addToList(string entry){
        // Add the entry to the list of all entries. 
        _allEntries.Add(entry);
    }

    public void showListContents(){
        foreach (var item in _allEntries){
            Console.WriteLine(item);
        }
    }
    // private void limitToFive()       limits the number of displayed entries to five so the user isn't overwhelmed.
}