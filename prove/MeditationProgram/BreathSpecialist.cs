// Give instructions specific to the breathing activity

public class BreathSpecialist : ActivityLeader{
    string _breathin = "Breath in...";
    string _breathout = "Breath out...";
    string _description;

    public void GiveDescriptionOfBreathing(){
    
    }
    public void TellGroupToBreathIn(){
        Console.WriteLine(_breathin);
    }
    public void TellGroupToBreathOut(){
        Console.WriteLine(_breathout);
    }


}