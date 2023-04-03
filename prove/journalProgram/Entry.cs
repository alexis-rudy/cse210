using System;
public class Entry{
    private string _date;
    private string _entry;

    private void getDate()
    {
        DateTime currentTime = DateTime.Now;
        string _date = currentTime.ToShortDateString();
    }

    public string getEntryFromUser(string entry)
    {
        // string entry = Console.ReadLine();
        _entry = entry;
        return entry;
    }

    private string addDateToEntry(string date)
    // Adds date to entry solely for when the user asks to view all entries made and not for saving in the database.
    {
        string entryWithDate = date + " : " + _entry;
        return entryWithDate;
    }
    public void getEntryWithDate(){}
        
        
}