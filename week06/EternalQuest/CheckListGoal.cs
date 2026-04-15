public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (_currentCount >= _targetCount)
            return 0;
        
        _currentCount++;
        
        if (_currentCount == _targetCount)
            return _points + _bonus;
        
        return _points;
    }

    public override string GetDetailsString()
    {
        string status = _currentCount >= _targetCount ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_currentCount}|{_targetCount}|{_bonus}";
    }
}
