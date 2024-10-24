using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Develop05
{
    public class ListingActivity : Activity
    {

        private int _count;
        private List<string> _prompts;

        public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
        {
            _count = count;
            _prompts = new List<string>();
        }
    }
}