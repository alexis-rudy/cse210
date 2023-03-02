using System;
    // The resonsibility of an activity is to control the progress of meditation
    public class Activity
    {
        private string _activityName;
        private string _activityDescription;
        private int _activityDuration;
        private bool _pause = false;
        private string _startMessage;
        private string _endMessage;
        public void GetStartMessage(string message)
        {
            _startMessage = message;
        }
        public int GetActivityDuration(){
            Console.WriteLine("How long do you want to do the activity for? ");
            int activityDuration = Convert.ToInt32(Console.ReadLine());
            _activityDuration = activityDuration;
            return activityDuration;
        }
        public void GetActivityDescription(string description){
            _activityDescription = description;
        }
        public void StartMedatation(string activity, string activityDescription){
            Console.WriteLine($"Welcome to the {activity} activity.");
            Console.WriteLine(activityDescription);
            GetActivityDuration();
        }
        public void EndMedataiton(string activity){
            Console.WriteLine($"You have completed the {activity} activity.");
        }
        public void GetAnimation(){
            PauseFiveSeconds();
            Console.Write("\b \b");
        }
        public void PauseFiveSeconds(){
            Thread.Sleep(5000);
        }
    }

