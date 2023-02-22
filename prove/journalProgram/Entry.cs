using System;
public class Entry{
    private string getDate()
    {
        DateTime currentTime = DateTime.Now;
        string _date = currentTime.ToShortDateString();
        return _date;
    }

    private string getEntryFromUser()
    {
        string entry = Console.ReadLine();
        return entry;
    }

    private void addDateToEntry(string date)
    {
        string entryWithDate = date + ":" + getEntryFromUser();
    }
}