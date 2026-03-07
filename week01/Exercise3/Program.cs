using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        

        Console.WriteLine("What is your guess?");
        int guessNumber = int.Parse(Console.ReadLine());

        while (guessNumber != magicNumber)
        {
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            Console.WriteLine("What is your guess?");
            guessNumber = int.Parse(Console.ReadLine());
       }

       Console.WriteLine("You guessed it!");
    }
}
 