public class Programming : Project{
    private string _language = "";
    
    public Programming(string name, string description, string startDate, string endDate) : base(name, description, startDate, endDate){}
    public Programming(string name, string description) : base(name, description){}
    public Programming(string description) : base(description){}


}