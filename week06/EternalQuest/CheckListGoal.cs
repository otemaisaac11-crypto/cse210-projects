using System;
using System.Collections.Generic;   
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount = 0;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _targetCount = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;

        // If goal is completed, give bonus points
        if (_currentCount == _targetCount)
        {
            return _points + _bonus;
        }

        return _points;
    }

    // Display goal details with progress
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";

        return $"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount}";
    }

    // Check if goal is complete
    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }
}