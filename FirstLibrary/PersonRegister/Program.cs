using System;
using FirstLibrary;

namespace PersonRegister
{
    class Program
    {
        static void Main()
        {
            Job job1 = new Job("Programmer", 420.69);

            Person person1 = new Person("Uvuvwevwevwe Onyetenyevwe Ugwemuhwem Osas", 69, job1);

            int idk = 1;

            while (true)
            {
                Console.WriteLine(idk + ". " + person1.name + ", " + person1.age + ", " + person1.job.jobName + ", he earns " + person1.job.jobSalary + "$");

                idk++;
            }
        }
    }
}