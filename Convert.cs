using System;
// The purpose of the Convert function is to change the start date from a string to a Date Time
public class Convert{
    private DateTime _convertedStartDate;
    private DateTime _convertedEndDate;

    // Instance of the Terminal for console use.
    Terminal terminal = new Terminal();

    // Getters and setters
    public DateTime GetConvertedStartDate(){
        return _convertedStartDate;
    }
    public DateTime GetConvertedEndDate(){
        return _convertedEndDate;
    }

    public DateTime convertDate(string date){
        // string dateInput = "Jan 1, 2009";
        // var parsedDate = DateTime.Parse(dateInput);
        // Console.WriteLine(parsedDate);
        // Displays the following output on a system whose culture is en-US:
        //       1/1/2009 00:00:00
        date = terminal.ReadDate();
        DateTime changedDate = DateTime.Parse(date);
        return changedDate;
    }
}