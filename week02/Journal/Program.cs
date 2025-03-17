using System;
using System;

class Program
{
    static void Main()// Main method to run the program
    {
        Journal myJournal = new Journal();  // Create a new Journal object
        bool running = true;// Variable to control the program loop

        while (running)
        {
            // Display the main menu options
            Console.WriteLine("\n Journal Menu ");// Display the main menu options
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Show journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");// Prompt the user to select an option

            string choice = Console.ReadLine(); // Get the user's menu selection

            // Handle user's menu selection
            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();  // Add a new journal entry
                    break;
                case "2":
                    myJournal.DisplayEntries();  // Show all saved entries
                    break;
                case "3":
                    myJournal.SaveToFile();  // Save entries to a file
                    break;
                case "4":
                    myJournal.LoadFromFile();  // Load entries from a file
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Exiting the program...");  // Exit the loop
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");  // Handle incorrect input
                    break;
            }
        }
    }
}
