using System;
public class Project{
    private string _name;
    private string _description;
    // get the date from the user then convert to a date with a while loop until they get it right
    private int _totalSteps;
    private string _stringStartDate;
    private string _stringEndDate;    
    private string _startDate;
    private string _projectedEndDate;
    private string _actualEndDate;

    private DateTime _allottedTime;
    private DateTime _actualTime;
    private string _type;
    private bool _completed = false;

    // Constructors
    public Project(string name, string description, string startDate, string endDate){}
    public Project(string description, string startDate, string endDate){}
    public Project(string name, string description){}
    public Project(string description){}
    public Project(){}

    // Create a new instance of Terminal to use in this class
    Terminal terminal = new Terminal();
    // Create a new instance of Convert to use in the class.
    Convert convert = new Convert();

    // Getters and Setters
    public string getStartDate(){
        return _stringStartDate;
    }
    public string getEndDate(){
        return _stringEndDate;
    }
    public string getName(){
        return _name;
    }
    public string getDescription(){
        return _description;
    }
    public DateTime getAllottedTime(){
        return _allottedTime;
    }
    public bool getCompleted(){
        return _completed;
    }

    // Calculation methods
    public TimeSpan calculateActualTime(){
        // Convert to DateTime before calculation.
        DateTime startDate = convert.convertDate(_startDate);
        DateTime actualEndDate = convert.convertDate(_actualEndDate);
        TimeSpan actualTime = startDate - actualEndDate;
        return actualTime;
    }
    public virtual double calculateProjectCost(){
        return 4.00;
    }
    public int getProgress(){
        return 35;
    }

}