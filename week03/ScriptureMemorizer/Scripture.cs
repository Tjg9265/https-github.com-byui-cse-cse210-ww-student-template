using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _rand = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] splitWords = text.Split(" ");
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    public string GetDisplayText()
    {
        string verseText = "";

        foreach (Word word in _words)
        {
            verseText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} - {verseText.Trim()}";
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _rand.Next(_words.Count);
            _words[index].Hide();  // The assignment allows re-hiding hidden words
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}
