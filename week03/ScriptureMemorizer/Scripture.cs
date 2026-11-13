public class Scripture
{
    private string _scriptureString;
    private Reference _reference;
    public Scripture(string scriptureString, Reference reference)
    {
        _scriptureString = scriptureString;
        _reference = reference; 
    }

    public void Display()
    {
        _reference.Display();
        Console.WriteLine(_scriptureString);
    }

    public int GetWordCount()
    {
        return _scriptureString.Split(' ').Length;
    }


    public void MakeStringWithBlanks(int wordsToBeBlanked)
    {
        Random random = new Random();
        string[] words = _scriptureString.Split(' ');
        int wordsBlanked = 0;
        while (wordsBlanked < wordsToBeBlanked)
        {
            int wordIndex = random.Next(GetWordCount());
            string randomWord = words[wordIndex];
            Word word = new Word(randomWord);
            if (!word.BlankedQuery())
            {
                string blankedWord = word.BlankWord();
                words[wordIndex] = blankedWord;
                wordsBlanked++;
            }
        }
        _scriptureString = string.Join(" ", words);
    }
}