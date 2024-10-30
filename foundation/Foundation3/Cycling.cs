using System.Dynamic;

class Cycling : Activity
{
    private double _speed;

    public Cycling(double duration, double speed) : base(duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetDuration())/60;
    }

    public override double GetPace()
    {
        return GetDuration()/   GetDistance();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration()} minutes)- Distance: {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()}min per km";
    }
}