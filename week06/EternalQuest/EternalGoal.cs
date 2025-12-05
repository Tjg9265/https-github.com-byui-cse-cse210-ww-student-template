public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
    }

    public override int RecordEvent()
    {
        return _points; // Never completes
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}
