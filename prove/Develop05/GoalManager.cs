using System.IO;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        int userParsedChoice = -1;
        while (userParsedChoice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu options");
            Console.WriteLine("1 - Create new Goal");
            Console.WriteLine("2 - List Goals");
            Console.WriteLine("3 - Save Goals");
            Console.WriteLine("4 - Load Goals");
            Console.WriteLine("5 - Record Event");
            Console.WriteLine("6 - Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();
            userParsedChoice = int.Parse(userChoice);

            if (userParsedChoice == 1)
            {
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("1 - Simple Goal");
                Console.WriteLine("2 - Eternal Goal");
                Console.WriteLine("3 - Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create?");
                userChoice = Console.ReadLine();
                userParsedChoice = int.Parse(userChoice);
                CreateGoal(userParsedChoice);
            }
            else if (userParsedChoice == 2)
            {
                ListGoalDetails();
                Console.WriteLine("");
            }
            else if (userParsedChoice == 3)
            {
                SaveGoals();
            }
            else if (userParsedChoice == 4)
            {
                Console.WriteLine("What is the nameof the file?");
                string fName = Console.ReadLine();
                LoadGoals(fName);
            }
            else if (userParsedChoice == 5)
            {
                ListGoalNames();
                Console.WriteLine("Wich goal did you accomplish?");
                string uOption = Console.ReadLine();
                int parsedUOption = int.Parse(uOption);
                RecordEvent(parsedUOption);
            }
            else if (userParsedChoice == 6)
            {
                Console.WriteLine("Congratulations for working hard on your goals. Keep it up!!!");
            }
            else
            {
                Console.WriteLine("Select a valid option");
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {(_goals[i].IsComplete() ? "[X]" : "[ ]")} {_goals[i].GetName()} - {_goals[i].GetDescription()} - {_goals[i].GetFrequency()}");
        }
    }

    public void CreateGoal(int option)
    {
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated whit this goal?");
        string points = Console.ReadLine();

        if (option == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (option == 2)
        {
            Console.WriteLine("How often do you want to verify compliance? (daily, weekly or monthly)");
            string frequency = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(name, description, points, frequency);
            _goals.Add(eternalGoal);
        }
        else if (option == 3)
        {
            Console.WriteLine("How namy times does this goal needto be accomplished for a bonus?");
            string target = Console.ReadLine();
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            string bonus = Console.ReadLine();
            int parsedTarget = int.Parse(target);
            int parsedBonus = int.Parse(bonus);
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, parsedTarget, parsedBonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent(int option)
    {
        _goals[option - 1].RecordEvent();
        Console.WriteLine(_goals[option - 1].GetType());
        if (_goals[option - 1].GetType() == typeof(ChecklistGoal))
        {
            if (_goals[option - 1].GetAmountCompleted() == _goals[option - 1].GetTarget() && _goals[option - 1].GetAmountCompleted() != -1)
            {
                _score += _goals[option - 1].GetBonus() + int.Parse(_goals[option - 1].GetPoints());
                
                Console.WriteLine($"Congratulations!! you have earned {_goals[option - 1].GetPoints()} points + a bonus of {_goals[option - 1].GetBonus()}!");
            }
            else
            {
                Console.WriteLine($"Congratulations!! you have earned {_goals[option - 1].GetPoints()} points!");
                _score += int.Parse(_goals[option - 1].GetPoints());
            }
        }
        else
        {
            Console.WriteLine($"Congratulations!! you have earned {_goals[option - 1].GetPoints()} points!");
            _score += int.Parse(_goals[option - 1].GetPoints()) - _goals[option - 1].CalculateSubstraction();
            Console.WriteLine(_goals[option - 1].CalculateSubstraction());
        }


    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the name of the file?");
        string fName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fName))
        {
            outputFile.WriteLine($"{GetScore()}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetType()},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{(goal.GetType() == typeof(ChecklistGoal) ? goal.GetAmountCompleted() : null)},{(goal.GetType() == typeof(ChecklistGoal) ? goal.GetTarget() : null)},{(goal.GetType() == typeof(ChecklistGoal) ? goal.GetBonus() : null)},{goal.IsComplete()},{(goal.GetType() == typeof(EternalGoal) ? goal.GetFrequency() : null)}");
            }

        }
    }

    public void LoadGoals(string fileName)
    {
        string fName = fileName;
        string[] lines = System.IO.File.ReadAllLines(fName);

        SetScore(int.Parse(lines[0]));

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(",");

            string isType = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            string amountCompleted = parts[4];
            string target = parts[5];
            string bonus = parts[6];
            string isCompleted = parts[7];
            string frequency = parts[8];

            if (isType == typeof(SimpleGoal).ToString())
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                simpleGoal.SetIsComplete(bool.Parse(isCompleted));
                _goals.Add(simpleGoal);
            }
            else if (isType == typeof(EternalGoal).ToString())
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points, frequency);
                eternalGoal.SetIsComplete(bool.Parse(isCompleted));
                _goals.Add(eternalGoal);
            }
            else
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, int.Parse(target), int.Parse(bonus));
                checklistGoal.SetIsComplete(bool.Parse(isCompleted));
                checklistGoal.SetAmountCompleted(int.Parse(amountCompleted));
                _goals.Add(checklistGoal);
            }
        }
    }

    private int GetScore()
    {
        return _score;
    }

    private void SetScore(int score)
    {
        _score = score;
    }
}