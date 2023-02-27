using System;
namespace Develop04
{
    public class Activity
    {
        private string _activityName;
        private string _activityDescription;
        private int _activityDuration;
        private bool _pause = false;
        private string _startMessage;
        private string _endMessage;

        // Constructor
        public Activity(string name, string description)
        {
            _activityName = name;
            _activityDescription = description;
        }

        public string GetStartMessage()
        {
            return _startMessage;
        }
        public void SetStartMessage(string message)
        {
            _startMessage = message;
        }
        public int GetActivityDuration(){
            Console.WriteLine("How long do you want to do the activity for? ");
            _activityDuration = int(Console.ReadLine);
        }
        public void ActivityStart(){
            Console.WriteLine(_startMessage);
        }
        public void ActivityEnd(){

        }
        public void PauseActivity(){

        }
        public bool IsPaused(){

        }

    }
}