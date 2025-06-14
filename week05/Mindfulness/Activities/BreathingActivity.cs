using System;
using System.Threading;

namespace MindfulnessProgram.Activities
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        { }

        protected override void PerformActivity()
        {
            int halfCycle = 4;
            int elapsed = 0;
            while (elapsed < Duration)
            {
                Console.Write("Breathe in...");
                CountDown(halfCycle);
                Console.Write("Breathe out...");
                CountDown(halfCycle);
                elapsed += halfCycle * 2;
            }
        }

        private void CountDown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write($" {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
