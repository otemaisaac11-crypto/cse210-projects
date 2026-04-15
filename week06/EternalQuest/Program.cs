using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal(manager);
            }
            else if (choice == "2")
            {
                RecordEvent(manager);
            }
            else if (choice == "3")
            {
                manager.DisplayGoals();
            }
            else if (choice == "4")
            {
                manager.DisplayScore();
            }
            else if (choice == "5")
            {
                break;
            }
            else if (choice == "6")
            {
                manager.SaveGoals();
                Console.WriteLine("Goals saved!");
            }
            else if (choice == "7")
            {
                manager.LoadGoals();
                Console.WriteLine("Goals loaded!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 7.");
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.Write("Type: ");
        string goalType = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description = Console.ReadLine();
        Console.Write("Goal points: ");
        int points = int.Parse(Console.ReadLine() ?? "0");

        if (goalType == "1")
        {
            manager.AddGoal(new SimpleGoal(name, description, points));
        }
        else if (goalType == "2")
        {
            Console.Write("Target count: ");
            int targetCount = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine() ?? "0");
            manager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonus));
        }
        else
        {
            Console.WriteLine("Unknown goal type. Goal not created.");
            return;
        }

        Console.WriteLine("Goal created successfully!\n");
    }

    static void RecordEvent(GoalManager manager)
    {
        if (manager.GoalCount == 0)
        {
            Console.WriteLine("No goals available. Create one first.");
            return;
        }

        Console.WriteLine("Select a goal to record an event for:");
        manager.DisplayGoalsWithIndexes();
        Console.Write("Enter goal number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int goalNumber) && goalNumber >= 1 && goalNumber <= manager.GoalCount)
        {
            manager.RecordEvent(goalNumber - 1);
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
}


    
