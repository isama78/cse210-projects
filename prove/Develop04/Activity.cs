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

    public void DisplayName()
    {
        Console.WriteLine(_name);
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string userTime = Console.ReadLine();
        int parsedUserTime = int.Parse(userTime);
        _duration = parsedUserTime;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity");
        Console.WriteLine("");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine("");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if(i < 10)
            {
                Console.Write("\b \b");
            }
            else
            {
                Console.Write("\b\b  \b\b");
            }
            
        }
    }
}