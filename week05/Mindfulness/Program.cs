using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Programa de Atención Plena ===");
            Console.WriteLine("1. Actividad de Respiración");
            Console.WriteLine("2. Actividad de Listado");
            Console.WriteLine("3. Actividad de Reflexión");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ListingActivity().Run();
                    break;
                case "3":
                    new ReflectingActivity().Run();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
