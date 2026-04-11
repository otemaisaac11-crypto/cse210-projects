using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} Activity ---");
        Console.WriteLine(_description);

        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        Pause(3);
    }

    public void End()
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        Pause(3);
    }

    public void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}