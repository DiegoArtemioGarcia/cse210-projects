using System;

public class Entry
{
    // Properties to store entry details
    public string Date { get; set; }  // Stores the entry date
    public string Prompt { get; set; }  // Stores the question/prompt
    public string Response { get; set; }  // Stores the user's answer

    // Constructor to initialize the entry with a prompt and response
    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToShortDateString(); // Automatically sets today's date
        Prompt = prompt;
        Response = response;
    }

    // Converts the entry into a string format for display
    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }
}
