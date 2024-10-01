using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What did you learn today? ",
        "Please share a fun experince you had in the past",
        "What is a good advice you will give to someone? ",
        "Do you have any favorite food? how it was your experince the first time you tried it. ",
        "What is the favorite part of your day? ",
        "What is a challenge you have experinced and how you have overcome it? ",
    };

    public string GetRandomPrompt(List<string> _prompts)
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}