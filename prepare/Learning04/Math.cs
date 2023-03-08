public class Math : Assignments{
    private string _textbookSection;
    private string _problems;

    public Math(string name, string topic, string selection, string problems):base(name, topic){
        _textbookSection = selection;
        _problems = problems;
    }
    public string GetHomeworkList(){
        return _textbookSection + "\n" + _problems;
    }
}