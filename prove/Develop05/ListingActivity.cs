using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Develop05
{
    public class ListingActivity : Activity
    {

        private int _count;
        private List<string> _prompts = new List<string>
        {
            "What is the most important thing on your life?",
            "What is a good motivator in your life and why?",
            "What helps you to remember that you are a child of God?",
            "THink about a spiritual experince that has changed your life"
        };

        public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
        {
            _count = count;
            _prompts = new List<string>();
        }

        public void Run()
        {

        }

        public void GetRandomPrompt()
        {

        }

        //public List<string> GetListFromUser()
        // {

        // }
    }
}