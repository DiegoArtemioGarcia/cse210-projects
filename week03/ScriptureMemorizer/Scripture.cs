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

        // Dividir el texto en palabras y guardarlas en la lista
        string[] wordArray = text.Split(' ');
        foreach (string w in wordArray)
        {
            words.Add(new Word(w));
        }
    }

    public void Display()
    {
        Console.Clear();  // Limpiar la pantalla cada vez que se muestra la escritura
        Console.WriteLine(reference.GetDisplayText()); // Muestra la referencia

        foreach (Word word in words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }

    // Ocultar palabras aleatorias
    public void HideRandomWords(int count)
    {
        Random rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            // Elegir una palabra aleatoria para ocultar, solo si no está oculta
            int index = rnd.Next(words.Count);
            while (words[index].IsHidden())  // Asegurarse de que la palabra no esté oculta
            {
                index = rnd.Next(words.Count);
            }

            words[index].Hide();
        }
    }

    // Verificar si todas las palabras están ocultas
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
