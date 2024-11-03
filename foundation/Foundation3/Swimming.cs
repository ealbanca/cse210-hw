using System;

public class Swimming : Activity
{
    private double _distance;
    private int _numberoflaps;
    public Swimming(DateTime date, int lenghtmin, double distance, int numberoflaps) : base(date, lenghtmin)
    {
        _distance = distance;
        _numberoflaps = numberoflaps;
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

    public int GetNumberoflaps()
    {

        return _numberoflaps;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} - Swimming ({_lenghtmin} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile, Number of Laps: {GetNumberoflaps()}";
    }

}