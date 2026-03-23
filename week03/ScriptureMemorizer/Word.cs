public class Word
{
    private string _text;
    private bool _isHidden;

    /* CONSTRUCTOR */
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    /* HIDE METHOD */
    public void Hide()
    {
        _isHidden = true;
    }

    /* CHECK IF HIDDEN */
    public bool IsHidden()
    {
        return _isHidden;
    }

    /* DISPLAY METHOD */
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}