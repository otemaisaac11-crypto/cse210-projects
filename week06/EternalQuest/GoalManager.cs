using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GoalCount => _goals.Count;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("Current Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void DisplayGoalsWithIndexes()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void SaveGoals()
    {
        List<string> data = new List<string>();
        data.Add(_score.ToString());

        foreach (Goal goal in _goals)
        {
            data.Add(goal.Serialize());
        }

        File.WriteAllLines("goals.txt", data);
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals file found.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");
        if (lines.Length == 0)
        {
            Console.WriteLine("Saved goals file is empty.");
            return;
        }

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            Goal goal = Goal.Deserialize(lines[i]);
            _goals.Add(goal);
        }
    }
}
