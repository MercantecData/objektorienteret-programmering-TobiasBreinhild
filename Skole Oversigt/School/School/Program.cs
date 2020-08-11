using System;
using System.Collections.Generic;
using School;

namespace School
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hold hold1 = new Hold(new List<Elev>(), 69);

            hold1.elevHold.Add(new Elev("Benny-Børge", 15));
            hold1.elevHold.Add(new Elev("Bent-Åge", 16));
            hold1.elevHold.Add(new Elev("Knud-Egner", 19));

            for (int i = 0; i < hold1.elevHold.Count; i++)
            {
                Console.WriteLine(hold1.elevHold[i].name + ", " + hold1.elevHold[i].age);
            }
        }
    }
}
