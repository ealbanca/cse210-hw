using System;
using System.Threading;

namespace Develop05
{
    public abstract class Activity
    {

        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;

        }
        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine($"{_description}");
            Console.WriteLine("Get ready...");
            ShowCountDown(3);

        }
        public void DisplayEndingMessage()
        {
            Console.WriteLine("Well Done!!");
            Console.WriteLine($"You have completed another{_duration}seconds of the {_name}");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("|");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("—");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
            Console.WriteLine(" ");
        }
    }
}