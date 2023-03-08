using System;
using System.Collections.Generic;
public class TimerSpecialist{
    // The responsibility of the TimerSpecialist class is to control the time settings.

    private int _duration;
    private List<string> _spinnerLines = new List<string>();
 

    TimerSpecialist(){
    _spinnerLines.Add("|");
    _spinnerLines.Add("/");
    _spinnerLines.Add("-");
    _spinnerLines.Add("\\");
    _spinnerLines.Add("|");
    _spinnerLines.Add("/");
    _spinnerLines.Add("|");
    _spinnerLines.Add("\\");
    }

    public void AskForDuration(){
        Console.WriteLine("How many seconds would you like to do this activity for?");
        _duration = Convert.ToInt32(Console.ReadLine());
    }
    public void Timer(){
        // Start the timer
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        // Pause

        for (DateTime i = startTime; i <= futureTime; i.AddSeconds(1)){
            if (i % 3 == 0){
                Thread.Sleep(ConvertToMilliseconds(5));
                addAnimation(5);
            }
        }

        // End the timer
        if (startTime >= futureTime){
            Console.WriteLine("Finished");
        }
    }

    public void addAnimation(int time){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        int i = 0;
          while (DateTime.Now < endTime){
            string s = _spinnerLines[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= _spinnerLines.Count){
                i = 0;
            }
          }
    }
    private int ConvertToMilliseconds(int seconds){
        return seconds * 1000;
    }

}