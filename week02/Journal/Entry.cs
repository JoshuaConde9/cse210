//save their response, the prompt, and the date as an Entry.

//Behavior: Get the input from the user.

using System;

public class Entry
{
    public string _entry = "";
    public DateTime _entryDate;
    public PromptGenerator _randomPrompt = new PromptGenerator();

    public string _prompt = "";


    public void RecordEntry()
    {
        _prompt = _randomPrompt.GenerateRandomPrompt();

        Console.WriteLine("Please write your journal entry:");
        _entry = Console.ReadLine();
        _entryDate = DateTime.Now;

        Console.WriteLine("Your entry was added.");
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_entryDate:f}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
    }
}