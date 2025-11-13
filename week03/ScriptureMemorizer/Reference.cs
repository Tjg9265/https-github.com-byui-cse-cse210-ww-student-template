public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for a single verse (e.g., John 3:16)
    public Reference(string book, int chapter, int verse)
    {
        // TODO: store the data
    }

    // Constructor for a verse range (e.g., Proverbs 3:5–6)
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        // TODO: store the data
    }

    public string GetDisplayText()
    {
        // TODO: return something like "John 3:16" or "Proverbs 3:5-6"
        return "";
    }
}
