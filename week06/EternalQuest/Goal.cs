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

    public virtual bool IsComplete()
    {
        return false;
    }

    public static Goal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        string type = parts[0];

        if (type == "SimpleGoal")
        {
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);
            return new SimpleGoal(name, description, points, isComplete);
        }
        else if (type == "ChecklistGoal")
        {
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            int currentCount = int.Parse(parts[4]);
            int targetCount = int.Parse(parts[5]);
            int bonus = int.Parse(parts[6]);
            return new ChecklistGoal(name, description, points, targetCount, bonus, currentCount);
        }
        else if (type == "EternalGoal")
        {
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            return new EternalGoal(name, description, points);
        }

        throw new InvalidOperationException("Unknown goal type.");
    }
}