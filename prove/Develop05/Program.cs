using System;
namespace Develop05
{

    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 4) running = false;
                else
                {
                    Console.WriteLine("Enter duration in seconds:");
                    int duration = int.Parse(Console.ReadLine());

                    Activity task = choice switch
                    {
                        1 => new BreathingActivity("Breathing Activity", "", duration),
                        2 => new ReflectingActivity("Reflection Activity", "", duration),
                        3 => new ListingActivity("Listing Activity", "", duration),
                        _ => null
                    };
                    task?.Run();
                }
            }
        }
    }
}