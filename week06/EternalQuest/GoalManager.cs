public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void RecordEvent(int index)
    {
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
        data.Add(goal.GetDetailsString());
    }

    File.WriteAllLines("goals.txt", data);
}



public void LoadGoals()
{
    string[] lines = File.ReadAllLines("goals.txt");

    _goals.Clear();

    
    _score = int.Parse(lines[0]);

    
    for (int i = 1; i < lines.Length; i++)
    {
        Console.WriteLine(lines[i]);
    }
}

}