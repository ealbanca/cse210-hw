using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(DateTime.Now, 10, 5),
            new StationaryBycicles(DateTime.Now, 10,5),
            new Swimming(DateTime.Now, 10, 5, 3)
        };

        foreach (var Activity in activities)
        {
            Console.WriteLine(Activity.GetSummary());
        }
    }
}