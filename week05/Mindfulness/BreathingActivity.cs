using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This helps you relax by breathing slowly.")
    {
    }

    public void Run()
    {
        Start();

        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);

            Console.WriteLine("Breathe out...");
            Countdown(3);

            time += 6;
        }

        
    }
}