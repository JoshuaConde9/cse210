using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Choose a valid option.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal do you want to create? ");

        string choice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter target times: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("Goal created.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete?");
        ListGoalNames();
        Console.Write("Enter number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Choose a valid option.");
            return;
        }

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");
        Console.WriteLine($"New total score: {_score}");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("Couldn't find the file.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);
                SimpleGoal g = new SimpleGoal(name, description, points);
                g.SetComplete(complete);
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal")
            {
                int amount = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal g =
                    new ChecklistGoal(name, description, points, target, bonus);
                g.SetAmountCompleted(amount);
                _goals.Add(g);
            }
        }

        Console.WriteLine("Goals loaded succesfully");
    }
}
