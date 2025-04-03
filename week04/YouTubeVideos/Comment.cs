using System;
using System.Collections.Generic;

// Clase que representa un comentario en un video
class Comment
{
    // Propiedades para almacenar el nombre del usuario y el texto del comentario
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor que inicializa el nombre y el texto del comentario
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    // Método para mostrar el comentario en la consola
    public void ShowComment()
    {
        Console.WriteLine($"   - {Name}: {Text}");
    }
}
