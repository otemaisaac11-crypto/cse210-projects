using System;

class Program
{
    static void Main(string[] args)
    {


    GoalManager manager = new GoalManager();

    while (true)
    {
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Show Goals");
        Console.WriteLine("4. Show Score");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Save Goals");
        Console.WriteLine("7. Load Goals");
        


        string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Create goal logic here...");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Record event logic here...");
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




        
    }
}   }


    
