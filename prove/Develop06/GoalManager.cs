using System;

public class GoalManager
{

    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {

    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is {_score}");
    }

    private void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }

    private void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: 1.Simple Goal 2. Eternal Goal 3. Checklist Goal ");
        Console.WriteLine("Which type of goal would you like to create?");
        string userselection = Console.ReadLine();

        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        Goal newgoal = null;

        if (userselection == "1")
        {
            newgoal = new SimpleGoal(name, description, points);

        }
        else if (userselection == "2")
        {
            newgoal = new EternalGoal(name, description, points);
        }
        else if (userselection == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            newgoal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (newgoal != null)
        {
            _goals.Add(newgoal);
            Console.WriteLine($"The Goal '{name}' has been added.");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void RecordEvent()
    {

    }

    private void SaveGoals()
    {

    }

    private void LoadGoals()
    {

    }

}


