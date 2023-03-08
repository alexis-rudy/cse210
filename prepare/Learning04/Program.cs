using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignments coding = new Assignments();
        Console.WriteLine(coding.GetSummary());
        Math math = new Math("Lloyd", "Math", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Writing write = new Writing("Adam Bratt", "Grapes of Wrath Essay", "Grapes of Wrath");
        Console.WriteLine(write);
    }
}