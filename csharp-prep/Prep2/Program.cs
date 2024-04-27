using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int gradePer = int.Parse(userInput);

        string letter  = "";

        if (gradePer >= 90)
        {
            letter = "A";
        }
        else if (gradePer >= 80)
        {
            letter = "B";
        }
        else if (gradePer >= 70)
        {
            letter = "C";
        }
        else if (gradePer >= 60)
        {
            letter= "D";
        }
        else 
        {
            letter= "F";
        }

        Console.WriteLine($"Your Garde is {letter}");
        
        if (gradePer >= 70)
            {
                Console.WriteLine("Congratulations!");
            }
            else
                {
                    Console.WriteLine("It was not this time. Do your best and try again");
                }
    }
}