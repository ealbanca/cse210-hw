using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Hared", "Math Assignment");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Edwin", "fractions", "27", "1-3");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignmnet assignmnet3 = new WritingAssignmnet("Annie", "Paper", "The Book");
        Console.WriteLine(assignmnet3.GetSummary());
        Console.WriteLine(assignmnet3.GetWritingInformation());


    }
}