using System;

public class ReflectionActivity : Activity
{
    public ReflectionActivity()
        : base("Reflection", "Think about a time you were strong.")
    {
    }

    public void Run()
    {
        Start();

        string[] prompts =
        {
            "Think of a time you did something hard.",
            "Think of a time you helped someone."
        };

        string[] questions =
        {
            "Why was it meaningful?",
            "What did you learn?",
            "How did you feel?"
        };

        Random rand = new Random();

        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Pause(3);

        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine(questions[rand.Next(questions.Length)]);
            Pause(4);
            time += 4;
        }

        
    }
}