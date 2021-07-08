using System;
using System.Collections.Generic;
using Job;

namespace Person
{
    public class Person
    {
        public string name;
        public int age;
        public Job.Job job;

        public Person(string name, int age, Job.Job job) // Constructor
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }
    }
}
