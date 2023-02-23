using System.IO;
public class Save{
    private string _content;
    private string _filename;

    public void saveToFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.Write(_content);
            // Figure out how to write to JSON file
        }
    }
}