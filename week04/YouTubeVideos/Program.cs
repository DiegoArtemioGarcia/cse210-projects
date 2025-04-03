using System;


class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Aprendiendo JavaScript", "Juan Pérez", 600);
        video1.AddComment(new Comment("Carlos", "¡Excelente explicación!"));
        video1.AddComment(new Comment("María", "Me ayudó mucho, gracias."));
        video1.AddComment(new Comment("Luis", "¡Genial, sigue así!"));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video("POO en Pyton", "Ana López", 900);
        video2.AddComment(new Comment("Pedro", "Muy claro el concepto de clases."));
        video2.AddComment(new Comment("Lucía", "Gracias por este contenido."));
        video2.AddComment(new Comment("Miguel", "Lo mejor que he visto sobre POO."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Estructuras de Datos", "José García", 1200);
        video3.AddComment(new Comment("Andrea", "Ahora entiendo listas y pilas."));
        video3.AddComment(new Comment("Roberto", "Buen material de estudio."));
        video3.AddComment(new Comment("Elena", "Me encantó el video, gracias."));

        videos.Add(video3);

        // Mostrar la información de todos los videos
        Console.WriteLine("📌 LISTA DE VIDEOS 📌\n");
        foreach (var video in videos)
        {
            video.ShowVideoDetails();
        }
    }
}