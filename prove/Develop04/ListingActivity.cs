using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private List<string> _userPrompts = new List<string>();

    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetUserPrompts();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, _prompts.Count);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[randomNumber]} ---");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
    }

    public void GetUserPrompts()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine("Well Done!");
        Console.WriteLine("");
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");
    }

    public List<string> GetListFromUser()
    {

        return _userPrompts;
    }
}