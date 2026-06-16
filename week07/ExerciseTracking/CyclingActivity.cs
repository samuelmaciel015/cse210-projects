public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(string date, int length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override float CalculateDistance()
    {
        return (_speed / 60) * _length;
    }
    public override float CalculatePace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min) - Distance {CalculateDistance()} km, Speed:{_speed} kph, Pace: {CalculatePace()} min per km";
    }
}
