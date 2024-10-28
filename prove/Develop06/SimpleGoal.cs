class SimpleGoal : Goal
{
    private bool _IsComplete;
    
    public SimpleGoal(string name, string description, string points) : base(name,description,points)
    {
    }

    public override void RecordEvent()
    {
        _IsComplete = true;
    }

    public override bool IsComplete()
    {
        return  _IsComplete;
    }

    public override string GetDetailsString()
    {
        if(IsComplete())
        {
            return $"[x] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_shortName}, {_description}, {_points}, {IsComplete()}";
    }
}