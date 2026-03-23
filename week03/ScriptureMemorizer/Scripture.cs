

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    /*CONSTRUCTOR*/
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }

    }

    /*DISPLAY SCRIPTURE METHOD*/
    public string GetDisplayText()
    {
        string result = "";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {result}";
    }

    public void HideRandomWord(int count = 3)
    {
        List<int> hiddenIndices = new List<int>();
        for (int i = 0; i < count && hiddenIndices.Count < _words.Count; i++)
        {
            int index;
            do
            {
                index = _random.Next(0, _words.Count);
            } while (hiddenIndices.Contains(index));
            
            hiddenIndices.Add(index);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
    
    
}