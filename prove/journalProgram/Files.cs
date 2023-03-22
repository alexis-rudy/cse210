using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
public class Files{
    string _filename;
    private Load loader = new Load();

    public string getFileName()
    {
        Console.Write("What is the name of the file: ");
        _filename = Console.ReadLine();
        return _filename;        
    }
    public void writeToFile(string filename){
        List<string> entriesListForFile = loader.getEntryList();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(entriesListForFile);
        }
    }
    public void openFile(string file){
        File.Open(file, FileMode.OpenOrCreate);
    }          

    public void closeFile(string file)
    {
        
    }     
          
}