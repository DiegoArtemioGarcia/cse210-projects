using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Actividad de Respiración", "Esta actividad te ayudará a relajarte caminando mientras inhalas y exhalas lentamente. Despeja tu mente y concéntrate en tu respiración.") 
    { }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine("Inhala...");
            ShowCountDown(4);
            Console.WriteLine("Exhala...");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }
}
