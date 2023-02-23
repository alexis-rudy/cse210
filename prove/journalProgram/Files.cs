using System;
using System.IO;
using System.Text;
public class Files{
    string _filename;

    public string getFileName()
    {
        Console.Write("What is the name of the file: ");
        _filename = Console.ReadLine();
        return _filename;        
    }

    public void openFile(string file){
        File.Open(file, FileMode.OpenOrCreate);
    }          

    public void closeFile(string file)
    {
        
    }     
          
}