using System.Diagnostics;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"Date:{_date} Duration:({_minutes} mins) Distance:({GetDistance()} km) Speed:({GetSpeed()} kph) Pace:({GetPace()} min/km)";
    }
}


