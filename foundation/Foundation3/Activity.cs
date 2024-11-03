using System;

public abstract class Activity
{

    protected DateTime _date;
    protected int _lenghtmin;

    public Activity(DateTime date, int lenghtmin)
    {
        _date = date;
        _lenghtmin = lenghtmin;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public int Getlenght()
    {
        return _lenghtmin;
    }

    public void SetLenght(int lenghtmin)
    {
        _lenghtmin = lenghtmin;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} - {this.GetType().Name} ({_lenghtmin} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}