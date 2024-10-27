using System;
using System.Reflection.Metadata;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base("", "", "")
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public void RecordEvent()
    {

    }

    public bool isComplete()
    {

    }

    public string GetDetailsString()
    {

    }

    public string GetStringRepresentation()
    {

    }
}