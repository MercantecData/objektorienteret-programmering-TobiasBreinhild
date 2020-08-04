using System;
using Job;

namespace FirstLibrary
{
    public class Person
    {
        public string name;
        public int age;
        public Job.Job job;

        public Person(string name, int age, Job.Job job) // Consructor
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }
    }
}
