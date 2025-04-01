using System;
using System.Collections.Generic;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string w in wordArray)
        {
            words.Add(new Word(w));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.GetDisplayText());

        foreach (Word word in words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }

    public void HideRandomWords(int count)
    {
        Random rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rnd.Next(words.Count);
            while (words[index].IsHidden())
            {
                index = rnd.Next(words.Count);
            }
            words[index].Hide();
        }
    }

    public bool AreAllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
