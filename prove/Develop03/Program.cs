using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Moroni", 10, 5, 6);
        Console.WriteLine(ref1.GetDisplayVerses());

        /*Reference ref2 = new Reference("Moroni", 10, 1, 5);
        Console.WriteLine(ref2.GetDisplayVerses());*/

    }
}