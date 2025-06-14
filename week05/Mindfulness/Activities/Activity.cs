using System;
using System.Threading;

namespace MindfulnessProgram.Activities
{
    public abstract class Activity
    {
        private string _name;
        private string _description;
        private int _duration;  // seconds

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"--- {_name} ---\n{_description}\n");
            Console.Write("Enter duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out _duration) && _duration > 0)
            {
                Console.WriteLine("\nGet ready...");
                AnimateDelay(3);
                PerformActivity();
                End();
            }
            else
            {
                Console.WriteLine("Invalid duration. Returning to menu.");
                Thread.Sleep(1500);
            }
        }

        protected abstract void PerformActivity();

        private void End()
        {
            Console.WriteLine("\nWell done!");
            Console.WriteLine($"You completed {_name} for {_duration} seconds.");
            AnimateDelay(3);
        }

        protected void AnimateDelay(int seconds)
        {
            string[] spinner = { "|", "/", "-", "\\" };
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(250);
                Console.Write("\b");
            }
            Console.WriteLine();
        }

        protected int Duration => _duration;
    }
}
