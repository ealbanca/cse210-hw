using System;
using System.Reflection.Metadata;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        int pointsgained = _points;

        if (_amountCompleted == _target)
        {
            pointsgained += _bonus;
            Console.WriteLine($"The goal {_shortName} has been completed. Total points: {pointsgained}");
        }
        else
        {
            Console.WriteLine($"The goal {_shortName} has been recorded. Points gained: {pointsgained}");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} (Completed {_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}