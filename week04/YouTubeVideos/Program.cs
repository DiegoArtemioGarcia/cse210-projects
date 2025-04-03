
// Clase principal donde se ejecuta el programa
class Program
{
    static void Main()
    {
        // Lista donde almacenaremos los videos creados
        List<Video> videos = new List<Video>();

        // Creación del primer video
        Video video1 = new Video("Aprendiendo JavaScript", "Juan Pérez", 600);
        video1.AddComment(new Comment("Carlos", "¡Excelente explicación!"));
        video1.AddComment(new Comment("María", "Me ayudó mucho, gracias."));
        video1.AddComment(new Comment("Luis", "¡Genial, sigue así!"));

        videos.Add(video1); // Agregamos el video a la lista

        // Creación del segundo video
        Video video2 = new Video("POO", "Ana López", 900);
        video2.AddComment(new Comment("Pedro", "Muy claro el concepto de clases."));
        video2.AddComment(new Comment("Lucía", "Gracias por este contenido."));
        video2.AddComment(new Comment("Miguel", "Lo mejor que he visto sobre POO."));

        videos.Add(video2); // Agregamos el video a la lista

        // Creación del tercer video
        Video video3 = new Video("Html y css", "José García", 1200);
        video3.AddComment(new Comment("Andrea", "Ahora entiendo."));
        video3.AddComment(new Comment("Roberto", "Buen material de estudio."));
        video3.AddComment(new Comment("Elena", "Me encantó el video, gracias."));

        videos.Add(video3); // Agregamos el video a la lista

        // Mostrar la información de todos los videos almacenados en la lista
        Console.WriteLine(" LISTA DE VIDEOS \n");
        foreach (var video in videos)
        {
            video.ShowVideoDetails();
        }
    }
}