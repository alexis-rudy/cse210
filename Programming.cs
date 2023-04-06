using System;
public class Programming : Project{
    private string _language = "";
    
    public Programming(string name, string description, DateTime startDate, DateTime endDate) : base(name, description, startDate, endDate){}
    public Programming(string description, DateTime startDate, DateTime endDate) : base(description, startDate, endDate){}

    public Programming(string name, string description) : base(name, description){}
    public Programming(string description) : base(description){}


}