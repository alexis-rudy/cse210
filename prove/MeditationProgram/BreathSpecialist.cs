// Give instructions specific to the breathing activity

public class BreathSpecialist : ActivityLeader{
    private string _breathin = "Breath in...";
    private string _breathout = "Breath out...";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public void GiveDescriptionOfBreathing(){
        Console.WriteLine(_description);
    }
    public void TellGroupToBreathIn(){
        Console.WriteLine(_breathin);
    }
    public void TellGroupToBreathOut(){
        Console.WriteLine(_breathout);
    }


}