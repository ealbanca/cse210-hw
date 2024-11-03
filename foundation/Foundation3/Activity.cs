using System;

public abstract class Activity
{

    public DateTime _date;
    public int _lenght;

    public Activity(DateTime date, int lenght)
    {
        _date = date;
        _lenght = lenght;
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
        return _lenght;
    }

    public void SetLenght(int lenght)
    {
        _lenght = lenght;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} ({_lenght} min): - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}