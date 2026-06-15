public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points) { }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
    public override int GetPoints()
    {
        return base.GetPoints();
    }
}