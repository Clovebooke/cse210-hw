using System;
using MindfulnessProgram.Activities;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program\n1. Breathing\n2. Reflecting\n3. Listing\n4. Exit");
                Console.Write("Choose an option: ");
                switch (Console.ReadLine())
                {
                    case "1": new BreathingActivity().Start(); break;
                    case "2": new ReflectingActivity().Start(); break;
                    case "3": new ListingActivity().Start(); break;
                    case "4": exit = true; break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Thread.Sleep(1000); break;
                }
            }
            Console.WriteLine("Thank you for practicing mindfulness today!");
        }
    }
}
