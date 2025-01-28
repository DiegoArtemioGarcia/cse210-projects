using System;
//
public class Job
{
   public string _company; //save the company name
   public string _jobTitle; //save the job title
   public int _startYear; //save the start year
    public int _endYear; //save the end year

    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }

}