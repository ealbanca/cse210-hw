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
        Console.WriteLine("Menu Options");
        string userInput;
        do
        {
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            userInput = Console.ReadLine();


            switch (userInput)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }
        } while (userInput != "6");
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
        ListGoalDetails();
        Console.WriteLine("Enter the index of the goal to record an event for: ");
        int index = int.Parse(Console.ReadLine());

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        var goal = _goals[index];
        goal.RecordEvent();

        if (goal.IsComplete())
        {
            _score += goal.GetPoints(); // Points are added when completed.
        }
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals have been saved successfully.");
    }

    public void LoadGoals()
    {

        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        _goals.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(':');
                var goalType = parts[0];
                var details = parts[1].Split(',');

                Goal goal = null;
                switch (goalType)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                        if (bool.Parse(details[3])) goal.RecordEvent();
                        break;

                    case "EternalGoal":
                        goal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[4]), int.Parse(details[5]));
                        for (int i = 0; i < int.Parse(details[3]); i++) goal.RecordEvent();
                        break;
                }
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }

}


