using System;

class Program
{
    static void Main(string[] args)
    {
        Journal thejournal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        Entry anEntry = new Entry();


        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nWelcome to your Journal");
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string newPrompt = prompt.GetRandomPrompt(prompt._prompts);
                thejournal.AddEntry(newPrompt);
            }
            else if (choice == "2")
            {
                thejournal.DisplayAll();
            }
            else if (choice == "3")
            {
                thejournal.LoadFromFile();
            }
            else if (choice == "4")
            {
                thejournal.SaveToFile();
            }
            else if (choice == "5")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
        Console.WriteLine("See you next time!");
    }

}
