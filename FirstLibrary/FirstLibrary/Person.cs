using System;

namespace FirstLibrary
{
    public class Person
    {
        public string name;
        public int age;
        public Job job;

        public Person(string name, int age, Job job) // Consructor
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }
    }

    public class Job
    {
        public string jobName;

        public Job(string jobName) // Consructor
        {
            this.jobName = jobName;
        }
    }


}
