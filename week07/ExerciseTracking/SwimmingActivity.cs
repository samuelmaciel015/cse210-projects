public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override float CalculateDistance()
    {
        return _laps * 50 / 1000;
    }
    public override float CalculateSpeed()
    {
        return (CalculateDistance() / _length) * 60;
    }
    public override float CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min) - Distance {CalculateDistance()} km, Speed:{CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }
}