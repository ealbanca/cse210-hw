using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);


        /*Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int magicNumber = int.Parse(magic);*/

        int guessedNumber;
        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessedNumber = int.Parse(guess);
               
            if (guessedNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guessedNumber < number)
            {
                Console.WriteLine("Higher");
            }

        } while (guessedNumber != number);
        Console.WriteLine("You guessed it!");
    }
}