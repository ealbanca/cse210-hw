using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

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

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void Run()
    {

    }
    public string GetRandomPrompt()
    {

    }

    public string GetRandomQuestion()
    {

    }

    public void DisplayPropmpt()
    {

    }

    public void DisplayQuestions()
    {

    }
}
