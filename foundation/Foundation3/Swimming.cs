class Swimming : Activity
{
    private int _lapsNum;

    public Swimming(double duration, int lapsNum) : base(duration)
    {
        _lapsNum = lapsNum;
    }

    public override double GetDistance()
    {
        return _lapsNum * 50 /1000;
    }

    public override double GetPace()
    {
        return GetDuration()/GetDistance();
    }
    public override double GetSpeed()
    {
        return (GetDistance()/GetDuration())*60;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} minutes)- Distance: {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()}min per km";
    }
}