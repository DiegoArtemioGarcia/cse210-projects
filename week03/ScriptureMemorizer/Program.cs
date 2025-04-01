using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.")
        };

        bool allWordsHidden = false;

        while (!allWordsHidden)
        {
            Console.Clear();
            foreach (Scripture scripture in scriptures)
            {
                scripture.Display();
            }

            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim();

            if (input == "quit")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else if (string.IsNullOrEmpty(input))
            {
                scriptures[0].HideRandomWords(1);
                Console.WriteLine("Hiding a word..."); // Depuración
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter to hide words or type 'quit' to exit.");
            }

            allWordsHidden = scriptures[0].AreAllWordsHidden();
        }

        Console.WriteLine("Final Scripture:");
        scriptures[0].Display();
    }
}


