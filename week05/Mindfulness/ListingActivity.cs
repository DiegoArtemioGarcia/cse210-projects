using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() 
        : base("Actividad de Listado", "Esta actividad te ayudará a reflexionar sobre las cosas buenas de tu vida al hacerte enumerar tantas cosas como puedas en un área determinada.")
    {
        _prompts = new List<string>()
        {
            "¿Quiénes son las personas que aprecias?",
            "¿Cuáles son tus fortalezas personales?",
            "¿A qué personas has ayudado esta semana?",
            "¿Cuándo has sentido el Espíritu Santo este mes?",
            "¿Quiénes son algunos de tus héroes personales?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Comenzando en...");
        ShowCountDown(5);

        List<string> userItems = GetListFromUser();

        Console.WriteLine($"Has enumerado {userItems.Count} elementos.");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Elemento: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        return items;
    }
}
