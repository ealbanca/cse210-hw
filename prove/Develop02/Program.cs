using System;

class Program
{
    static void Main(string[] args)
    {
        Journal _theJournal = new Journal();
        PromptGenerator thePrompt = new PromptGenerator();


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
                string newPrompt = thePrompt.GetRandomPrompt(thePrompt._prompts);
                Console.WriteLine($"{newPrompt}");
            }
            else if (choice == "2")
            {
                /*thejournal.DisplayAll();*/
                Console.WriteLine("test2");
            }
            else if (choice == "3")
            {
                /*thejournal.LoadFromFile();*/
                Console.WriteLine("test3");
            }
            else if (choice == "4")
            {
                /*thejournal.SaveToFile();*/
                Console.WriteLine("test4");
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
