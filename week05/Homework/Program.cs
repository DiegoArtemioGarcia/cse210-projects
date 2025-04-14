using System;

class Program
{
    static void Main(string[] args)
    {
        // Prueba de Assignment (base)
        Assignment a1 = new Assignment("Diego Garcia", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        // Prueba de MathAssignment
        MathAssignment m1 = new MathAssignment("Roberto Rodriguez", "Fractions", "5.0", "2-23");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine();

        // Prueba de WritingAssignment
        WritingAssignment w1 = new WritingAssignment("Diana Schneckenburger", "Geography", "Valleys and Mountains");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}
