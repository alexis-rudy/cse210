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
        try
        {
            openFile(file);
            
        }catch (FileNotFoundException){
            Console.WriteLine($"{file} not found.");
            Console.WriteLine("Creating new file...");
            using (StreamWriter newfile = File.CreateText(file));
        }
    }
}