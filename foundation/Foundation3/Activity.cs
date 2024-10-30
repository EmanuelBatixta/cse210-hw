class Activity
{
    private double _duration;

    public Activity(double duration)
    {
        _duration = duration;
    }
    
    public virtual double GetDuration()
    {
        return _duration;
    }
    
    public string GetDate()
    {
        DateTime _date = DateTime.Today;
        return _date.ToString("dd MMM yyyy");
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{GetDate()} ########## ({GetDuration()} minutes): Distance: {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()}min per km";
    }
}