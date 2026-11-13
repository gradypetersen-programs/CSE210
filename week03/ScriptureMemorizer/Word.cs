public class Word
{
    private string _word;
    private bool _isBlanked;

    public Word(string word)
    {
        _word = word;

        if (word.Contains("_"))
        {
            _isBlanked = true;
        }
        else
        {
            _isBlanked = false;
        }
    }

    public bool BlankedQuery()
    {
        return _isBlanked;
    }

    public string BlankWord()
    {
        string blankedWord = "";
        int wordLength = _word.Length;
        for (int i = 0; i < wordLength; i++)
        {
            blankedWord += '_';
        }
        _isBlanked = true;
        return blankedWord;
    }
}