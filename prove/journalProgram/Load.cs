using System;
using System.Collections.Generic;

public class Load{
    private List<string> _allEntries = new List<string>();
    // private Dictionary<string, string> database;

    public List<string> getEntryList(){
        List<string> entryList = new List<string>();
        entryList = _allEntries;
        return entryList;
    }
    // public void getEntries(Dictionary<string, string> database)
    // {
    //     foreach (var item in database.Values)
    //     {
    //         _allEntries.Add(item);
    //     }
    // }\
    public void addToList(string entry){
        // Add the entry to the list of all entries. 
        // Console.WriteLine(entry);
        _allEntries.Add(entry);
        // Console.WriteLine(_allEntries);
    }

    public void showListContents(){
        foreach (string item in _allEntries){
            Console.WriteLine(_allEntries);
            Console.WriteLine(item);
        }
    }
    // private void limitToFive()       limits the number of displayed entries to five so the user isn't overwhelmed.
}