using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Moroni", 10, 5, 6);
        Scripture scr1 = new Scripture(ref1, "5 And by the power of the Holy Ghost ye may know the truth of all things.\n" +
        "6 And whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.");




        while (!scr1.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scr1.GetDisplayText());
            //Console.WriteLine(ref1.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }
            else if (input == "")
            {
                scr1.HideRandomWords(3);
            }
        }

        if (scr1.IsCompletelyHidden())
        {
            Console.Clear();
        }

        /*Reference ref2 = new Reference("Moroni", 10, 1, 5);
        Console.WriteLine(ref2.GetDisplayVerses());*/

    }
}