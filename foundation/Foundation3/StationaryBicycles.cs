using System;

public class StationaryBycicles : Activity
{
    private double _distance;
    public StationaryBycicles(DateTime date, int lenghtmin, double distance) : base(date, lenghtmin)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return _lenghtmin / _distance;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }

}