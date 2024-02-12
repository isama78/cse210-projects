public class EternalGoal : Goal
{
    private bool _eventRecorded = false;
    private DateTime _startOfDay;

    private string _frequency;

    TimeSpan difference;

    private int _substraction;
    public EternalGoal(string name, string description, string points, string frequency) : base(name, description, points)
    {
        _startOfDay = DateTime.Today;
        _substraction = int.Parse(points);
        _frequency = frequency;
    }

    public override void RecordEvent()
    {
        _eventRecorded = true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

    public override string GetFrequency()
    {
        return _frequency;
    }

    // Método para verificar si _isComplete cambió durante el día y restar puntos si es necesario
    public override int CalculateSubstraction()
    {
        if (_frequency == "daily")
        {
            difference = DateTime.Today - _startOfDay;
            if (difference.TotalDays >= 1)
            {
                _startOfDay = DateTime.Today;
                if (!_eventRecorded)
                {
                    return _substraction;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }
        else if (_frequency == "weekly")
        {
            difference = DateTime.Today - _startOfDay;
            if (difference.TotalDays >= 7)
            {
                _startOfDay = DateTime.Today;
                if (!_eventRecorded)
                {
                    return _substraction;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        else if (_frequency == "monthly")
        {
            difference = DateTime.Today - _startOfDay;
            if (difference.TotalDays >= 30)
            {
                _startOfDay = DateTime.Today;
                if (!_eventRecorded)
                {
                    return _substraction;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        else
        {
            Console.WriteLine("bad frequency");
            return 0;
        }
    }
}

