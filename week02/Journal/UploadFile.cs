public class UploadFile
{
    public string _fileName;
    public List<string> GetEntries()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        List<string> entries = new List<string>();
        foreach (string line in lines)
        {
            string[] parts = line.Split(" || ");

            foreach (string entry in parts)
            {
                if (entry != "")
                {
                    entries.Add(entry); 
                }
            } 
        }
        return entries;
    }
}   