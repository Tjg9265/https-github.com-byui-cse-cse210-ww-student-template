public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        // TODO: store the text and start as not hidden
    }

    public void Hide()
    {
        // TODO: mark this word as hidden
    }

    public void Show()
    {
        // Optional helper if you ever need to unhide
    }

    public bool IsHidden()
    {
        // TODO: return whether the word is hidden
        return false;
    }

    public string GetDisplayText()
    {
        // If hidden, later we’ll return "_____"
        // If not, we’ll return the actual word
        return "";
    }
}
