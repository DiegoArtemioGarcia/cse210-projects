using System;

class Program
{
    static void Main(string[] args)
    {
        Message();

        string nombre = PromptNombreUsusario();
        int numero = PromptNumer();

        int squaredNumber = SquareNumber(numero);

        DisplayResult(nombre, squaredNumber);
    }

    static void Message()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptNombreUsusario()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptNumer()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}