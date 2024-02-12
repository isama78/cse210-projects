public abstract class Goal
{
    protected string  _shortName;
    protected string _description;
    protected string _points;
    protected bool _isComplete;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public bool IsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool complete)
    {
        _isComplete = complete;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetFrequency()
    {
        return "";
    }
    
    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }

    public void SetDescription(string desc)
    {
        _description = desc;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }

    public virtual void SetAmountCompleted(int amount)
    {

    }

    public virtual void SetTarget(string target)
    {
        
    }

    public virtual void SetBonus(string bonus)
    {
        
    }

    public string GetPoints()
    {
        return _points;
    }

    public virtual string GetDescription()
    {
        return $"{_description}";
    }

    public virtual int GetTarget()
    {
        return -1;
    }

    public virtual int GetBonus()
    {
        return -1;
    }

    public virtual int GetAmountCompleted()
    {
        return -1;
    }

    public virtual int CalculateSubstraction()
    {
        return 0;
    }
    
}