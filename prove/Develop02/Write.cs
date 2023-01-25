public class Write{
        public List<string> prompts = new List<string>();
        string _journalPrompt;
        string _userResponse;
    public string getDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
}