class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // en segundos
    private List<Comment> Comments { get; set; } = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void ShowVideoDetails()
    {
        Console.WriteLine($"🎬 Título: {Title}");
        Console.WriteLine($"👤 Autor: {Author}");
        Console.WriteLine($"⏳ Duración: {Duration} segundos");
        Console.WriteLine($"💬 Comentarios ({GetCommentCount()}):");

        foreach (var comment in Comments)
        {
            comment.ShowComment();
        }
        Console.WriteLine();
    }
}