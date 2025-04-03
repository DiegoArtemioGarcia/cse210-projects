
// Clase que representa un video de YouTube
class Video
{
    // Propiedades del video: título, autor y duración en segundos
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // en segundos

    // Lista privada de comentarios asociados al video
    private List<Comment> Comments { get; set; } = new List<Comment>();

    // Constructor que inicializa los valores del video
    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
    }

    // Método para agregar un comentario al video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Método que devuelve la cantidad de comentarios que tiene el video
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Método que muestra toda la información del video, incluyendo los comentarios
    public void ShowVideoDetails()
    {
        Console.WriteLine($" Título: {Title}");
        Console.WriteLine($" Autor: {Author}");
        Console.WriteLine($" Duración: {Duration} segundos");
        Console.WriteLine($" Comentarios ({GetCommentCount()}):");

        // Recorremos la lista de comentarios y los mostramos
        foreach (var comment in Comments)
        {
            comment.ShowComment();
        }
        Console.WriteLine(); // Salto de línea para mejor presentación
    }
}