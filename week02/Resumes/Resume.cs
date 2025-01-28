using System;

public class Resume
{ 
    public string _name; //save the name
    public List<Job> _jobs = new List<Job>();//List of jobs belonging to the person. Uses a list (List<Job>) to store multiple jobs.
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (Job job in _jobs)
        {
            job.DisplayJobInfo();
        }
    }
}