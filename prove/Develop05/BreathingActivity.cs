using System;

namespace Develop05
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, int duration) : base("Breathing Activity", "This activity will help you to relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
        {

        }
        public void Run()
        {
            DisplayStartingMessage();
            for (int i = 0; i < _duration / 6; i++)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(3);
                Console.WriteLine("Breathe out...");
                ShowCountDown(3);
            }
            DisplayEndingMessage();
        }
    }

}

