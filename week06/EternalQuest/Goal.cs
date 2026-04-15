using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract string Serialize();

    public virtual string GetDetailsString()
    {
        return $"[] {_name} ({_description})";
    }

    public static Goal Deserialize(string data)
    {
        var parts = data.Split('|');
        if (parts[0] == "SimpleGoal")
            return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
        if (parts[0] == "EternalGoal")
            return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
        if (parts[0] == "ChecklistGoal")
            return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[4]));
        throw new Exception("Unknown goal type.");
    }
}
