using System;

public class Running : Activity
{
    private double _distancemiles;

    public Running(DateTime date, int lenghtmin, double distancemiles) : base(date, lenghtmin)
    {
        _distancemiles = distancemiles;
    }

    public override double GetDistance()
    {
        return _distancemiles;
    }

    public override double GetSpeed()
    {
        return _distancemiles / _lenghtmin * 60;
    }

    public override double GetPace()
    {
        return _lenghtmin / _distancemiles;
    }
}