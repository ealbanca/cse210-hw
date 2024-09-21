using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int enteredNumber;

        do
        {
            Console.Write("Enter number: ");
            string userEntry = Console.ReadLine();
            enteredNumber = int.Parse(userEntry);
            numbers.Add(enteredNumber);

        } while( enteredNumber !=0);

        /*Compute the sum, or total, of the numbers in the list.*/
        int sum= 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        /*Compute the average of the numbers in the list.(I added a minus 1, since I don't want to add the "0"(zero) to the average*/

        double average = ((double)sum)/(numbers.Count-1);
        Console.WriteLine($"The Average is: {average}");

        /*Find the maximum, or largest, number in the list.*/

        int max = numbers[0];
        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The Max number is:{max}");
    }
}