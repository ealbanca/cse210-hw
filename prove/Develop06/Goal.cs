using System;

public abstract class Goal
{

    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {

        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName}: {_description}";
    }

    public abstract string GetStringRepresentation();

}