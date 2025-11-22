using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0) return;

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));

        return $"{referenceText} — {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
