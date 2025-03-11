using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumbers = random.Next(1, 101);

        int guess = -1;

        
        while (guess != magicNumbers)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumbers > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumbers < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}