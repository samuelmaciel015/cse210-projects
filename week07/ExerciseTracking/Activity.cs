public class Activity 
{

    protected string _date;
protected int _length;

public Activity(string date, int length)
{
    _date = date;
    _length = length;
}

public virtual float CalculateDistance() { return 0; }
public virtual float CalculateSpeed() { return 0; }
public virtual float CalculatePace() { return 0; }
public virtual string GetSummary() { return ""; }
}