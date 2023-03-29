// The responsibility of an activity is to control the progress of meditation
public class ActivityLeader{
    private string _startMessage;
    private string _endMessage;
    private string _activityName;

    public string GetActivityName(string activityName){
        _activityName = activityName;
        return activityName;
    }
    public void WelcomeWithStartMessage(){
        _startMessage = $"Welcome to the {_activityName} Activity.";
        Console.WriteLine(_startMessage);
    }

    public void StopWithEndMessage(){
        _endMessage = $"You have completed the {_activityName} Activity.";
        Console.WriteLine(_endMessage);
    }

}