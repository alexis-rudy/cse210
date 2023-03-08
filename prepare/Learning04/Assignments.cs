public class Assignments{
    private string _studentName;
    private string _topic;

    public Assignments(){
        _studentName = "John Smith";
        _topic = "None";
    }

    // Ask why you need a constructor with parameters.
    public Assignments(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary(){
        return _studentName + '-' + _topic;
    }
}