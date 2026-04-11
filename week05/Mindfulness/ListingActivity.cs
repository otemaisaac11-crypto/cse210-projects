using System;

public class ListingActivity : Activity
{
    public ListingActivity()
        : base("Listing", "List good things in your life.")
    {
    }

    public void Run()
    {
        Start();

        string[] prompts =
        {
            "Who do you appreciate?",
            "What are your strengths?"
        };

        Random rand = new Random();

        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Console.WriteLine("Start listing items:");

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        
    }
}