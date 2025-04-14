using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base("Actividad de Reflexión", "Esta actividad te ayudará a reflexionar sobre los momentos de tu vida en los que has demostrado fortaleza y resiliencia.")
    {
        _prompts = new List<string>()
        {
            "Piensa en una ocasión en la que defendiste a otra persona.",
            "Piensa en una ocasión en la que hiciste algo realmente difícil.",
            "Piensa en una ocasión en la que ayudaste a alguien necesitado.",
            "Piensa en una ocasión en la que hiciste algo verdaderamente desinteresado."
        };

        _questions = new List<string>()
        {
            "¿Por qué fue significativa esta experiencia para usted?",
            "¿Alguna vez has hecho algo parecido?",
            "¿Cómo empezaste?",
            "¿Cómo te sentiste cuando lo terminaste?",
            "¿Qué hizo que esta vez fuera diferente a otras?",
            "¿Qué es lo que más te gusta de esta experiencia?",
            "¿Qué podrías aprender de esta experiencia para otras situaciones?",
            "¿Qué aprendiste sobre ti mismo a través de esta experiencia?",
            "¿Cómo puedes mantener esta experiencia en la mente en el futuro?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Reflexiona en...");
        ShowSpinner(5);
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
}
