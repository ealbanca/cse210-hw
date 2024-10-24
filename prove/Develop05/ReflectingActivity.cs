using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class ReflectingActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        ""
    };

    private List<string> _questions = new List<string>
    {

    };

    public ReflectingActivity(string name, string description, int duration, List<string> _prompts, List<string> _questions) : base(name, description, duration)
    {
        _prompts = _prompts;
        _questions = _questions;
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
