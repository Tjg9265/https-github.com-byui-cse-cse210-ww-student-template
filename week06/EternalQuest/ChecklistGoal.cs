public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int completed = 0)
        : base(name, desc, points)
    {
        _amountCompleted = completed;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return $"{box} {_shortName} ({_description}) -- {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}
