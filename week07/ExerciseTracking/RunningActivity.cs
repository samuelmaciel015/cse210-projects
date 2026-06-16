public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(string date, int length, float distance) : base (date, length)
    {
        _distance = distance;
    }
    public override float CalculateSpeed()
    {
        return (_distance / _length) * 60;
    }
    public override float CalculatePace()
    {
        return _length / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min) - Distance {_distance} km, Speed:{CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }
}