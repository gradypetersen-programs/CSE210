public class Write
{
    public List<string> _textList;
    public string _fileName;

    public void WriteFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine("Journal:");
            foreach (string line in _textList)
            {
                outputFile.WriteLine(line);
            }

        }
    }
}