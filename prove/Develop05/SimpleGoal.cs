public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        SetIsComplete(true);
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}