// Give instructions specific to the breathing activity

public class BreathSpecialist : ActivityLeader{
    private string _breathein = "Breathe in";
    private string _breatheout = "Breathe out";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public void GiveDescriptionOfBreathing(){
        Console.WriteLine(_description);
    }
    public void TellGroupToBreathIn(){
        Console.WriteLine(_breathein);
        AddPeriodsToBreathe();
    }
    public void TellGroupToBreathOut(){
        Console.WriteLine(_breatheout);
        AddPeriodsToBreathe();
    }
    private void AddPeriodsToBreathe(){
        for (int i = 5; i > 0; i--){
            Console.WriteLine(".");
            Thread.Sleep(1000);
        }
    }

}