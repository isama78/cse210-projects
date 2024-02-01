using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        Console.WriteLine("Well Done!");
        Console.WriteLine("");
        DisplayEndingMessage();
    }
}