using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something very difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel afterward?",
        "What made this time different?",
        "What did you learn about yourself?",
        "How can you apply this in the future?"
    };

    public ReflectingActivity()
        : base("Reflection",
        "This activity helps you reflect on times of strength and resilience.")
    { }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("Press Enter when you are ready...");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            string q = GetRandomQuestion();
            Console.WriteLine($"> {q}");
            ShowSpinner(5);
            elapsed += 5;
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
}
