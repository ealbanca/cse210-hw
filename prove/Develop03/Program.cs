using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Moroni", 10, 5, 6);
        Scripture scr1 = new Scripture(ref1, "5 And by the power of the Holy Ghost ye may know the truth of all things.\n" +
        "6 And whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.");



        Console.WriteLine(ref1.GetDisplayText());
        Console.WriteLine(scr1.GetDisplayText());

        /*Reference ref2 = new Reference("Moroni", 10, 1, 5);
        Console.WriteLine(ref2.GetDisplayVerses());*/

    }
}