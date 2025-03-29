using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "escrituras.txt";

        List<Scripture> scriptures = LoadScripturesFromFile(filePath);

        // Si no se encuentran escrituras, finalizar el programa
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No se encontraron escrituras.");
            return;
        }

        bool allWordsHidden = false;

        // Mostrar la escritura completa
        while (!allWordsHidden)
        {
            foreach (Scripture scripture in scriptures)
            {
                scripture.Display();  // Muestra la escritura
            }

            // Solicitar al usuario que presione Enter o escriba 'quit'
            Console.WriteLine("Presione Enter para ocultar palabras, o escribe 'quit' para salir.");
            string input = Console.ReadLine();  // Captura la entrada del usuario

            // Si el usuario escribe 'quit', termina el programa
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Saliendo...");
                break;
            }
            // Si el usuario presiona Enter (sin escribir nada), oculta una palabra aleatoria
            else if (input == "")
            {
                // Ocultar una palabra aleatoria de la primera escritura
                if (scriptures.Count > 0)
                {
                    scriptures[0].HideRandomWords(1); // Ocultar una palabra aleatoria
                }
            }
            else
            {
                Console.WriteLine("Entrada no reconocida. Escriba 'quit' para salir o presione Enter para ocultar palabras.");
            }

            // Verificar si todas las palabras están ocultas
            allWordsHidden = scriptures[0].AreAllWordsHidden();
        }

        // Mostrar la escritura final con todas las palabras ocultas
        foreach (Scripture scripture in scriptures)
        {
            scripture.Display();

        }
    }

    // Método para cargar escrituras desde un archivo
    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        // Verificar si el archivo existe
        if (File.Exists(filePath))
        {
            Console.WriteLine("¡Archivo encontrado!");
            string[] lines = File.ReadAllLines(filePath);

            // Procesar cada línea del archivo
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    string refText = parts[0];
                    string text = parts[1];

                    // Separar la referencia en libro, capítulo y versículo(s)
                    string[] refParts = refText.Split(' ');
                    string book = refParts[0];
                    string[] chapterVerse = refParts[1].Split(':');
                    int chapter = int.Parse(chapterVerse[0]);
                    string[] verses = chapterVerse[1].Split('-');
                    int verseStart = int.Parse(verses[0]);
                    int verseEnd = (verses.Length > 1) ? int.Parse(verses[1]) : verseStart;

                    Reference reference = new Reference(book, chapter, verseStart, verseEnd);
                    scriptures.Add(new Scripture(reference, text));
                }
            }
        }
        else
        {
            Console.WriteLine($"Error: El archivo {filePath} no se encontró.");
        }

        return scriptures;
    }
}
