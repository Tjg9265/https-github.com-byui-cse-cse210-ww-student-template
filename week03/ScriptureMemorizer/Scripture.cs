using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        // TODO:
        // 1. store the reference
        // 2. split the text into words
        // 3. create Word objects and put them in the list
    }

    public string GetDisplayText()
    {
        // TODO: build a string with the reference + all word display texts
        return "";
    }

    public void HideRandomWords(int numberToHide)
    {
        // TODO: randomly choose some words and hide them
        // (You will implement this later)
    }

    public bool IsCompletelyHidden()
    {
        // TODO: check if all words are hidden
        return false;
    }
}
