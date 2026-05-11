public class Resume
{
    //attributes
    public string _name;
    public List<Job> _jobs = new List<Job>();

    //methods
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}