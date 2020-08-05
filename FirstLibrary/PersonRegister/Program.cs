using System;
using System.Collections.Generic;
using Person;
using Job;
using MathLibrary;

namespace PersonRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            MathLibrary.Maths mathStuff = new MathLibrary.Maths();

            Job.Job job1 = new Job.Job("Programmer", 420.69);

            Person.Person person1 = new Person.Person("Uvuvwevwevwe Onyetenyevwe Ugwemuhwem Osas", 69, job1);

            int idk = 1;

            while (idk < 10)
            {
                Console.WriteLine(idk + ". " + person1.name + ", " + person1.age + ", " + person1.job.jobName + ", he earns " + person1.job.jobSalary + "$");

                idk++;
            }

            Console.WriteLine(mathStuff.Plus("4", "6"));
            Console.WriteLine(mathStuff.Minus("15", "5"));
            Console.WriteLine(mathStuff.Multiply("2", "5"));
            Console.WriteLine(mathStuff.Divide("50", "5"));   
        }
    }
}