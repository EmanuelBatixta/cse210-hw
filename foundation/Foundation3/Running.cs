class Running : Activity
{
    private double _distance;

    public Running(double duration, double distance) : base(duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetDuration()/_distance;
    }

    public override double GetSpeed()
    {
        return 60/GetPace();
    }
    
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} minutes)- Distance: {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()}min per km";
    }
}