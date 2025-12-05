public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string desc, int points)
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    // MUST be overridden
    public abstract int RecordEvent();

    public virtual bool IsComplete()
    {
        return false;
    }

    // Used for saving to file
    public abstract string GetStringRepresentation();
}
