public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if(_amountCompleted == _target)
        {
            SetIsComplete(true);
        }
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override int GetTarget()
    {
        return _target;
    }

    public override int GetBonus()
    {
        return _bonus;
    }

    public override int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

    public override string GetDescription()
    {
        string[] parts = _description.Split("--");
        _description = parts[0];
        return $"{_description} -- Currently completed {_amountCompleted}/{_target}";
    }

}