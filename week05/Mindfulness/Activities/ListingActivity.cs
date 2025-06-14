using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram.Activities
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private Random _rand = new Random();

        public ListingActivity()
            : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        { }

        protected override void PerformActivity()
        {
            string prompt = _prompts[_rand.Next(_prompts.Count)];
            Console.WriteLine($"\n-- {prompt} --");
            Console.Write($"You have 5 seconds to think...");
            AnimateDelay(5);
            Console.Clear();
            Console.WriteLine(prompt);
            Console.WriteLine($"Start listing! You have {Duration} seconds.");

            var items = new List<string>();
            DateTime end = DateTime.Now.AddSeconds(Duration);

            while (DateTime.Now < end)
            {
                Console.Write("> ");
                string entry = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entry))
                    items.Add(entry);
            }

            Console.WriteLine($"\nYou listed {items.Count} items!");
        }
    }
}
