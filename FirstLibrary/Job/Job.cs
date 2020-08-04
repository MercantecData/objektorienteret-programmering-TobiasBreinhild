using System;

namespace Job
{
    public class Job
    {
        public string jobName;
        public double jobSalary;

        public Job(string jobName, double jobSalary) // Consructor
        {
            this.jobName = jobName;
            this.jobSalary = jobSalary;
        }
    }
}
