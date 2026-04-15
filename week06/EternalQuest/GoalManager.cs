using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public int GoalCount => _goals.Count;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal.");
            return;
        }

        int points = _goals[index].RecordEvent();
        _score += points;
        Console.WriteLine($"You earned {points} points.");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void SaveGoals()
    {
        var lines = new List<string> { _score.ToString() };
        foreach (var goal in _goals)
            lines.Add(goal.Serialize());
        File.WriteAllLines("goals.txt", lines);
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved file.");
            return;
        }

        var lines = File.ReadAllLines("goals.txt");
        if (lines.Length == 0) return;

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
            _goals.Add(Goal.Deserialize(lines[i]));
    }
}
