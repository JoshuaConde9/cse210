// Show the user a random prompt (from a list that you create

//Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
/*Who was the most interesting person I interacted with today?
What was the best part of my day?
How did I see the hand of the Lord in my life today?
What was the strongest emotion I felt today?
If I had one thing I could do over today, what would it be?
*/


//Behavior: Give a prompt to the user.

using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    
    {
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "In what ways did I show love, patience, or kindness today?",
        "What challenge did I face today, and how did it help me grow closer to God?",
        "What moment today brought me the most peace or joy?",
    };

    public Random _random = new Random();

    public string GenerateRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        return prompt;
    }
}