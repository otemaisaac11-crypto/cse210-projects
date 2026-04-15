using System;

class Program
{
    static void Main(string[] args)
    {
        var manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(manager); break;
                case "2": RecordEvent(manager); break;
                case "3": manager.DisplayGoals(); break;
                case "4": manager.DisplayScore(); break;
                case "5": manager.SaveGoals(); Console.WriteLine("Goals saved!"); break;
                case "6": manager.LoadGoals(); Console.WriteLine("Goals loaded!"); break;
                case "7": return;
                default: Console.WriteLine("Please enter a number from 1 to 7."); break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose goal type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine() ?? "0");

        if (type == "1")
            manager.AddGoal(new SimpleGoal(name, description, points));
        else if (type == "2")
            manager.AddGoal(new EternalGoal(name, description, points));
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine() ?? "0");
            manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
            Console.WriteLine("Invalid goal type.");
    }

    static void RecordEvent(GoalManager manager)
    {
        if (manager.GoalCount == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        manager.DisplayGoals();
        Console.Write("Goal number: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= manager.GoalCount)
            manager.RecordEvent(number - 1);
        else
            Console.WriteLine("Invalid number.");
    }
}


    
