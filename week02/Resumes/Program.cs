using System;

class Program
{
    static void Main(string[] args)
    {
        //create two jobs (job1 and job2) with specific details 
        //(company, title, years).
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2018;


        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2018;
        job2._endYear = 2020;

        //create a resume (resume), assign a name to the person, and add the jobs to their list of employments.
        Resume myResume = new Resume();// create a new resume object
        myResume._name = "Diego Garcia";// assign a name to the person
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //use the DisplayResume() method to show the complete resume.
        myResume.DisplayResume();

    }
}