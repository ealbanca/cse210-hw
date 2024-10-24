using System;
using System.Collections.Generic;

namespace Develop05;

public class ReflectingActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you felt the love of our Savior",
        "Think of a time when the scriptures have stregthened your testimony ",
        "Think of a time when you visited the temple and learned something new",
        "Think of a time when you felt the Holy Ghost"
    };

    private List<string> _questions = new List<string>
    {
        "What did you feel after that experience?",
        "What did you learn from that experience?",
        "How did that experince changed your life?",
        "Have you had any other experience like that?"
    };

    public ReflectingActivity(string name, string description, int duration) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strenght  and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ", duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
    //public string GetRandomPrompt() {}

    //public string GetRandomQuestion(){ }
    //public void DisplayPropmpt() {}
    //public void DisplayQuestions(){}
}
