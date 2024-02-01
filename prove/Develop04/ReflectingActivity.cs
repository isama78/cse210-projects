public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<int> _shownQuestions = new List<int>();

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter");
        Console.ReadLine();
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            DisplayQuestion();
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }

    public string GetRandomQuestion()
    {
        while (_shownQuestions.Count != _questions.Count)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(0, _questions.Count);
            if (!_shownQuestions.Contains(randomNumber))
            {
                Console.WriteLine(randomNumber);
                _shownQuestions.Add(randomNumber);
                return _questions[randomNumber];
            }
        }
        Console.WriteLine("AHORA SI RANDOM");
        Random randomGenerator2 = new Random();
        int randomNumber2 = randomGenerator2.Next(0, _questions.Count);
        return _questions[randomNumber2];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
        ShowSpinner(4);
        Console.WriteLine("");
    }

}