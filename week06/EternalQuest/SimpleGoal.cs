public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points, bool complete = false)
        : base(name, desc, points)
    {
        _isComplete = complete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string box = _isComplete ? "[X]" : "[ ]";
        return $"{box} {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
