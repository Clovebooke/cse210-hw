using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private static readonly List<string> Prompts = new()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn today?",
        "What am I grateful for today?"
    };

    private static readonly Random _random = new();

    public string GetRandomPrompt()
    {
        return Prompts[_random.Next(Prompts.Count)];
    }
}
