using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Data Scientist";
        job1._company = "Apple";
        job1._startYear = 2011;
        job1._endYear = 2012;


        Job job2 = new Job();
        job2._jobTitle = "IT engineer";
        job2._company = "Amazon";
        job2._startYear = 2012;
        job2._endYear = 2014;

        Resume myResume = new Resume();
        myResume._name = "Edwin Albancando Robles";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}