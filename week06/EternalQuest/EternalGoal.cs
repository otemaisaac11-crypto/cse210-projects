using System;
using System.Collections.Generic;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points; // Always gives points, never completes
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }
}