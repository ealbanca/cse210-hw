using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.WriteLine("Enter number");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            numbers.Add(number);

        }

        //Compute sum
        double sum = 0;

        foreach (int element in numbers)
        {
            sum += element;
        }
        Console.WriteLine($"The sum is: {sum}");

        // compute average
        double average = sum / (numbers.Count - 1);

        Console.WriteLine($"The average is: {average}");

        //find the largest number
        double max = numbers[0];

        foreach (int element in numbers)
        {
            if (element > max)
            {
                max = element;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

    }


}