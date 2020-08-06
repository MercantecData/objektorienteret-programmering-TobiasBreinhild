using System;
using System.Collections.Generic;
using LokaleLibrary;
using HoldLibrary;
using AnsatLibrary;
using ElevLibrary;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Hold hold = new Hold();

            hold.elevHold1.Add(new Elev("Benny-Børge"));
            hold.elevHold1.Add(new Elev("Bent-Åge"));
            hold.elevHold1.Add(new Elev("Knud-Egner"));

            hold.elevHold2.Add(new Elev("Egon-Karsten"));
            hold.elevHold2.Add(new Elev("Mona-Lis"));
            hold.elevHold2.Add(new Elev("Karl-Lief"));

            hold.elevHold3.Add(new Elev("Margrethe-Povl"));
            hold.elevHold3.Add(new Elev("Bo"));
            hold.elevHold3.Add(new Elev("Yvonne-Mads"));

            hold.elevHold1.ForEach(elev => Console.WriteLine(hold.elevHold1)); // Printer "System.Collections.Generic.List`1[ElevLibrary.Elev]"

            for (int i = 0; i < hold.elevHold1.Count; i++)
            {
                Console.WriteLine(hold.elevHold1[i]); // Printer "ElevLibrary.Elev"
            }
        }
    }
}
